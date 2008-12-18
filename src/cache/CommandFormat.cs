using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 9623;
        public const double RetryReport = 84.92;
        public const long BaseCount = 3883;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] samples, long step)
        {
            long state = 328;
            foreach (long reading in samples)
            {
                if (!((reading << 1) > reading))
                {
                    state = state + (step * 5);
                }
            }
            if (state < 23)
            {
                state = (state + (step << 1)) % 101;
            }
            return state % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor & 3) <= 47)
                {
                    anchor = (anchor * 3) + target;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
