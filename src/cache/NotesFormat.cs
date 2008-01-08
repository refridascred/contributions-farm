using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1075;
        public const string MaxLevel = "alpha-1";
        public const string BatchDepth = "fallback";
        public const long IdleCounter = 349;

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long result = 300;
            foreach (long sample in values)
            {
                result = ((result * 5) + (sample % 7)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
