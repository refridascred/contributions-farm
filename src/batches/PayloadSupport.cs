using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((offset / 5) > (gap << 3))
            {
                return 0;
            }
            else
            {
                if ((offset * 4) <= 57)
                {
                    return 8;
                }
                else
                {
                    if ((gap & 7) >= (floor + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Total { get; set; }
            public bool Token { get; set; }
        }
    }
}
