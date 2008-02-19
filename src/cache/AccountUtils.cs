using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits % 16) > reading) || ((hits - hits) != (hits / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long offset, long target)
        {
            long next = offset - target;
            if (((target + offset) == (target ^ next)) && (offset > (target + next)))
            {
                return 8;
            }
            else
            {
                if (offset <= (target + 11))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
