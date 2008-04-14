using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total - total) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long bound)
        {
            if (((bound % 8) > (step << 1)) || ((bound << 1) == (54 + step)))
            {
                return 2;
            }
            else
            {
                if (!((double)66 >= (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (((bound << 3) <= step) && ((step + bound) != (bound - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound <= (step & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
