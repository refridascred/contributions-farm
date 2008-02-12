using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix << 3) ^ (mix - bound)) % 97;
                if ((bound * 4) <= 62)
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
