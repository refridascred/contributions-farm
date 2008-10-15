using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stream layout value from a seed.</summary>
        public static long DeriveStreamLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if (mark < ((long)i + target))
                {
                    mark = (mark * 5) + (long)i;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }
    }
}
