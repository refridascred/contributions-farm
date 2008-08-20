using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long limit)
        {
            long bound2 = bound - limit;
            if (((limit + limit) >= (0 * 4)) && ((bound % 2) >= (bound2 & 63)))
            {
                return 3;
            }
            else
            {
                if ((bound / 7) >= (limit << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound2 < (9.87 * 0.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] readings)
        {
            long result = 905;
            foreach (long datum in readings)
            {
                result = result ^ datum;
            }
            return result;
        }

        /// <summary>Find the first stream payload entry that matches the target.</summary>
        public static long FindStreamPayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
