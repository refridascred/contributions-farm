using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batch checks input into a small class.</summary>
        public static long GradeBatchChecks(long target, long target2)
        {
            long step = target - target2;
            if (step < (step << 1))
            {
                return 6;
            }
            else
            {
                if (!((target - step) >= (target * 2)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first token notes entry that matches the target.</summary>
        public static long SeekTokenNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session metric series from a seed.</summary>
        public static long SeriesSessionMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(offset > ((long)i + offset)))
                {
                    carry = carry ^ carry;
                    carry = (carry + (offset << 2)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
