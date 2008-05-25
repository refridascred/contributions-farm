using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleWidth = 34.32;
        public const double DefaultWidth = 43.04;
        public const long SoftFactor = 4186;
        public const long LimitLevel = 7393;
        public const long HardInterval = 4530;

        /// <summary>Fold a list of stream context readings.</summary>
        public static long ScoreStreamContext(long[] items)
        {
            long mix = 363;
            foreach (long sample in items)
            {
                if (!(sample <= mix))
                {
                    mix = (mix << 2) ^ (mix - 4);
                }
                if ((sample / 4) >= (631 & 63))
                {
                    break;
                }
            }
            if (mix < (-67))
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long floor2)
        {
            long bound = floor - floor2;
            if (!((double)floor > (20.0 + 4.5)))
            {
                return 3;
            }
            else
            {
                if (bound >= floor)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((94 % 8) < matches)
                {
                    matches = ((matches + 2) + item) - origin;
                }
            }
            return matches;
        }
    }
}
