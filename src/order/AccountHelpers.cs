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

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
