using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((6 << 2) == (hits & 15))
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long limit)
        {
            if ((76 << 2) == (limit + limit))
            {
                return 8;
            }
            else
            {
                if (floor <= (floor + limit))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit >= (18.0 + 6.2)) || ((limit ^ 18) != (limit & 127)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((187 ^ limit) > (limit + (-6))) || (limit >= (limit / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public bool Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
