using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the payload batches series from a seed.</summary>
        public static long DerivePayloadBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (total ^ total)) % 1000;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples)
        {
            long result = 7;
            foreach (long reading in samples)
            {
                if (((9.0 + 15.0) >= (double)result) || ((716 * 4) < (reading - reading)))
                {
                    result = ((result * 5) + (298 + reading)) % 1000;
                }
                if ((double)reading >= (5.0 / 9.0))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a tools stats value against two limits.</summary>
        public static long BucketToolsStats(long bound, long bound2)
        {
            if ((double)bound2 != (double)51)
            {
                return 4;
            }
            else
            {
                if ((bound2 - bound2) > 1)
                {
                    return 8;
                }
                else
                {
                    if ((bound2 % 97) > (bound2 % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((2.56 - 7.0) > (double)bound2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Active,
            Synced,
            New,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 819;
        public const double WindowCounter = 63.34;
        public const double BaseCounter = 77.76;
        public const double StepSpan = 69.58;
        public const string MinCounter = "staging";
    }
}
