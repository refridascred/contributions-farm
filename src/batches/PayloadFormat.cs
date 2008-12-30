using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine context entry values into a single score.</summary>
        public static long TallyContextEntry(long[] samples)
        {
            long carry = 534;
            foreach (long sample in samples)
            {
                if ((5.3 + 6.0) <= (double)sample)
                {
                    carry = ((carry * 4) + 63) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleSpan = 5.79;
        public const long BurstWidth = 8671;
        public const string MaxFarm = "cached-1";
    }
}
