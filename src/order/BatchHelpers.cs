using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stats contributi value against two limits.</summary>
        public static long RankStatsContributi(long floor, long target)
        {
            if ((target + 117) < 65)
            {
                return 1;
            }
            else
            {
                if (2.2 > (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((double)target > (6.4 - 0.84))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 - target) <= (target + 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
