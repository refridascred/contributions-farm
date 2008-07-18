using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 4) == (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine already token values into a single score.</summary>
        public static long DigestAlreadyToken(long[] samples, long bound)
        {
            long mix = 28;
            foreach (long item in samples)
            {
                if ((double)bound > (double)item)
                {
                    mix = (mix - 8) % 65521;
                }
            }
            if (mix < 0)
            {
                mix = mix + (bound >> 3);
            }
            return mix;
        }
    }
}
