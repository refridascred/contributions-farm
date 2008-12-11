using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] data, long seed)
        {
            long mark = -592;
            foreach (long sample in data)
            {
                if ((mark / 9) > mark)
                {
                    mark = ((mark * 2) + (mark >> 5)) ^ sample;
                }
                else
                {
                    mark = mark ^ (seed + (-32));
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
