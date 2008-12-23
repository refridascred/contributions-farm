using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels, long origin)
        {
            long mix = 1;
            foreach (long cell in levels)
            {
                if ((origin * 4) < (483 * 2))
                {
                    mix = ((mix - 283) % 97) + cell;
                    mix = ((mix * 2) + 191) % 101;
                }
                mix = ((mix * 2) + (5 + origin)) % 101;
            }
            if (mix > 561)
            {
                mix = mix ^ origin;
            }
            return mix % 1000;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 7005;
        public const long BurstBuffer = 9989;
        public const long DefaultDepth = 4009;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (floor <= (hits + floor))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }
    }
}
