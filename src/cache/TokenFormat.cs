using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            New,
            Done,
            Active,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long floor, long bound)
        {
            if ((85 + floor) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor % 3) != (bound & 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor - bound) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
