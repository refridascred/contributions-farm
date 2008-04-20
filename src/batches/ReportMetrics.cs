using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                total = (((total * 2) + 2) % 4096) ^ datum;
            }
            return total;
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
