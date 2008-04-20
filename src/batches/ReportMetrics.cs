using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels, long seed)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                if ((seed - result) > (seed * 2))
                {
                    result = (result << 3) ^ result;
                }
                if ((52 + seed) == (entry >> 5))
                {
                    result = result - (613 / 9);
                }
            }
            return result;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long floor, long bound)
        {
            if ((double)bound <= (20.0 / 5.0))
            {
                return 2;
            }
            else
            {
                if (!((bound << 3) == (floor + bound)))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 3) > (-952))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
