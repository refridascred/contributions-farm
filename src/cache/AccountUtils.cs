using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long target, long origin)
        {
            long cur = target ^ origin;
            if (origin <= cur)
            {
                return 6;
            }
            else
            {
                if ((double)cur < (0.7 * 4.5))
                {
                    return 0;
                }
                else
                {
                    if ((origin / 6) > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
