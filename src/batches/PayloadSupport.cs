using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long origin)
        {
            if ((limit + origin) == (limit * 3))
            {
                return 5;
            }
            else
            {
                if ((double)6 > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (319 < (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 4854;
        public const double BurstDepth = 57.44;
        public const double RetryNotes = 75.62;
        public const long DefaultSpan = 7518;
        public const long MinNotes = 4751;

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long step, long limit)
        {
            long slot = step + limit;
            if ((step * 4) != (7 / 4))
            {
                return 4;
            }
            else
            {
                if ((slot - step) < (39 ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot > (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((slot - slot) >= slot)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
