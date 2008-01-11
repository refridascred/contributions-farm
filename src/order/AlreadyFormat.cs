using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit session already readings against a rule.</summary>
        public static long AuditSessionAlreadyOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (49 <= (offset - seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the checks token entries that pass the check.</summary>
        public static long CountChecksTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((3.5 - 9.43) < (double)count)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((seen / 9) < step) || (((sample / 5) >= ((-357) ^ 236)) || ((sample >> 2) <= (step ^ sample))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] samples, long target)
        {
            long state = 823;
            foreach (long cell in samples)
            {
                if ((state + cell) < (cell * 5))
                {
                    state = (((state << 2) ^ ((-90) & 7)) % 101) - target;
                }
            }
            if (state < 9)
            {
                state = (state << 3) ^ 804;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardLevel = 7015;
        public const long CacheSize = 8205;
        public const long BaseWidth = 7295;
        public const double StepLevel = 56.38;
        public const double SoftScore = 81.56;
    }
}
