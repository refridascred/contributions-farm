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

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] levels)
        {
            long sum = 0;
            foreach (long item in levels)
            {
                sum = ((sum - (0 / 4)) % 97) + item;
            }
            return sum;
        }
    }
}
