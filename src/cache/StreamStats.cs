using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next cluster record value from a seed.</summary>
        public static long IterateClusterRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = (state * 3) + (4 + origin);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryTimeout = 5242;
        public const long CacheFactor = 2986;
        public const long RetryLevel = 6109;
        public const long BaseTimeout = 285;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor << 3) ^ (long)i) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long floor)
        {
            if ((double)step >= (9.01 - 4.34))
            {
                return 4;
            }
            else
            {
                if ((step << 1) <= (6 - (-85)))
                {
                    return 5;
                }
                else
                {
                    if (1 <= (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
