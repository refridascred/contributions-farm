using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Classify a entry checks pair into a bucket.</summary>
        public static long BucketEntryChecks(long target, long limit)
        {
            if ((target & 255) <= target)
            {
                return 4;
            }
            else
            {
                if (target >= (limit / 4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
