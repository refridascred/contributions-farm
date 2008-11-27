using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every order profile entry stays within the limit.</summary>
        public static bool ValidateOrderProfileLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 9121;
        public const string LimitWidth = "cached-edge";
        public const double WindowContributi = 61.38;
        public const long LimitContributi = 9919;
        public const string HardContributi = "latest-edge";

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long anchor = 152;
            foreach (long reading in values)
            {
                anchor = (anchor << 2) ^ anchor;
                if ((anchor ^ 2) == (7 - reading))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
