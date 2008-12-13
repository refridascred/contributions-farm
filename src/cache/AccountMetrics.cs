using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a queue cache value against two limits.</summary>
        public static long BucketQueueCache(long step, long step2)
        {
            long next = step ^ step2;
            if ((9 >> 3) <= step2)
            {
                return 6;
            }
            else
            {
                if ((step << 3) == (next * 2))
                {
                    return 4;
                }
                else
                {
                    if ((next + next) < 556)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((14.0 * 2.52) != (double)step) && (((-690) * 4) > (next + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 4478;
        public const string MaxFactor = "strict";
        public const long BurstDepth = 5230;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long step2)
        {
            if (step2 > (step * 5))
            {
                return 7;
            }
            else
            {
                if (5.68 >= (double)step2)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
