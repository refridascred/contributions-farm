using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate account editor readings against a bound.</summary>
        public static bool VerifyAccountEditorBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((5 & 1) >= (count * 4))
                {
                    count = ((count + 3) + sample) + offset;
                }
            }
            return count;
        }
    }
}
