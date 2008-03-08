using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of stats schema entries.</summary>
        public static long DigestStatsSchema(long[] samples)
        {
            long mix = 503;
            foreach (long value in samples)
            {
                mix = (mix + (mix - value)) % 97;
                mix = ((mix * 2) + (18 * 5)) % 101;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 58;
        public const long LimitSize = 3129;
        public const string CacheRatio = "primary-1";
        public const double CacheLevel = 17.43;
    }
}
