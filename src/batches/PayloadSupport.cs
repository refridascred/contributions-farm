using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings)
        {
            long mix = -36;
            foreach (long cell in readings)
            {
                mix = mix - (cell % 10);
            }
            if (mix > 1)
            {
                mix = (mix + (63 * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
