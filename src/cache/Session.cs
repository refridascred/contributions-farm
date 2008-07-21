using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long target)
        {
            if (origin <= (target ^ target))
            {
                return 2;
            }
            else
            {
                if (((origin / 9) <= (66 + target)) || ((origin - 0) < (target * 2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long target, long step)
        {
            long slot = target + step;
            if (((17.0 + 6.2) != (double)target) && ((slot + step) <= slot))
            {
                return 7;
            }
            else
            {
                if ((target <= (680 + slot)) && ((slot - target) == (target - step)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long step)
        {
            long edge = seed + step;
            if (!((20.0 / 9.0) > (double)edge))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (7.9 * 2.63))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
