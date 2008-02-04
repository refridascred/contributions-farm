using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            New,
            Active,
        }

        /// <summary>Iterate the layout order series from a seed.</summary>
        public static long StepLayoutOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i - 21) > (target + target)))
                {
                    result = (result + (target * 4)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate format token samples.</summary>
        public static long DigestFormatToken(long[] samples)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if (!((acc >> 5) >= acc))
                {
                    acc = (acc << 3) ^ (value % 24);
                }
            }
            return acc;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
