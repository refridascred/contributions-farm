using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Locked,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long floor2)
        {
            if (((floor % 7) < (945 + floor2)) && ((floor2 & 15) >= (floor2 + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor <= floor2) || ((floor ^ (-89)) <= (floor2 % 16)))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 << 3) >= (floor ^ floor2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
