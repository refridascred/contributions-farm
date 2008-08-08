using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 9396;
        public const double RetryCommits = 86.5;
        public const long SoftCommits = 7277;

        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long CountFarmToolsHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((target ^ seen) <= (seen + 72)) || !((entry - entry) < (seen - target)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long target)
        {
            if ((target > (seed + seed)) || ((double)target < 4.9))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) == (seed + target))
                {
                    return 7;
                }
                else
                {
                    if ((0.5 * 15.0) > (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 3) > (38 >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long seed)
        {
            long span = origin - seed;
            if ((seed << 1) == (seed % 60))
            {
                return 3;
            }
            else
            {
                if ((seed - span) != (span - span))
                {
                    return 8;
                }
                else
                {
                    if (!((885 / 4) < seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
