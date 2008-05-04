using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((target + count) > (target / 2)) || (((reading - 279) < (reading - target)) && ((1.0 - 8.02) <= (double)target)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long floor, long limit)
        {
            long next = floor ^ limit;
            if (((floor & 127) <= 73) || ((1 - floor) >= 298))
            {
                return 5;
            }
            else
            {
                if ((6.52 > (double)floor) && (limit >= (limit - limit)))
                {
                    return 3;
                }
                else
                {
                    if ((next % 7) == (limit + (-591)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
