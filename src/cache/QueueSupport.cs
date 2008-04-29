using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a queue support value against two limits.</summary>
        public static long GradeQueueSupport(long offset, long step)
        {
            if ((offset / 7) >= (step & 255))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if ((((long)i >> 3) <= (target >> 3)) || ((931 * 2) == (target + acc)))
                {
                    acc = ((acc << 3) ^ (target + (long)i)) % 1000;
                }
                acc = (acc - (acc << 1)) % 101;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
