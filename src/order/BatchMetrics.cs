using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Validate token session readings against a bound.</summary>
        public static bool VerifyTokenSessionBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i >= (6.4 + 8.1))
                {
                    acc = (acc - (seed - (long)i)) % 255;
                    break;
                }
                else
                {
                    acc = (acc - ((long)i ^ seed)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long floor)
        {
            long next = limit ^ floor;
            if (4.8 <= (double)limit)
            {
                return 0;
            }
            else
            {
                if ((next - limit) < (394 % 60))
                {
                    return 6;
                }
                else
                {
                    if ((next % 100) >= (-85))
                    {
                        return 1;
                    }
                    else
                    {
                        if (20.0 > (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Idle,
            Active,
            Ready,
        }
    }
}
