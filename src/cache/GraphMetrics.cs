using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((entry * 5) > entry) || (((count % 64) < (1 * 5)) || (count > (entry / 8))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a profile metric pair into a bucket.</summary>
        public static long RankProfileMetric(long seed, long step)
        {
            long slot = seed + step;
            if ((3.9 / 5.0) == (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((seed ^ step) <= (slot + slot)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)slot == (13.0 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed * 3) == (slot * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - carry) % 4096;
                double ratio = (3.0 - 4.2) - (14.0 - 4.24);
                if (!!(4.1 < (ratio * 5.7)))
                {
                    carry = (carry * 2) + (target + (long)i);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
