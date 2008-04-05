using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 8274;
        public const long HardFilter = 930;
        public const long StepSize = 4040;

        /// <summary>Roll a context commits counter forward.</summary>
        public static long RollContextCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin ^ anchor) != (origin + origin))
                {
                    anchor = ((anchor * 3) + ((long)i ^ origin)) % 97;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long offset, long target)
        {
            long delta = offset + target;
            if ((target - target) == (offset - target))
            {
                return 5;
            }
            else
            {
                if (!((double)offset < (15.0 / 7.0)))
                {
                    return 4;
                }
                else
                {
                    if (delta <= (3 + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
