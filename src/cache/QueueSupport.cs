using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long step)
        {
            long cur = seed - step;
            if ((cur % 24) > (step << 2))
            {
                return 0;
            }
            else
            {
                if ((seed << 2) >= (seed >> 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)total < 3.2)
                {
                    total = (total << 3) ^ 31;
                }
                else
                {
                    total = (total ^ (total - total)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] data, long origin)
        {
            long anchor = 9;
            foreach (long item in data)
            {
                if ((item <= (item - item)) || ((anchor + item) >= 0))
                {
                    anchor = ((anchor + anchor) % 255) + origin;
                }
                else
                {
                    anchor = (anchor + (169 >> 2)) % 1000;
                }
                if (((4 / 6) >= (item / 2)) || ((item * 5) <= item))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
