using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Grade a already layout value against two limits.</summary>
        public static long BucketAlreadyLayout(long limit, long limit2)
        {
            if (7 > limit)
            {
                return 4;
            }
            else
            {
                if ((double)80 <= 6.96)
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit2) != (limit >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((15 - limit) != (limit >> 3)) && (5.88 > (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
