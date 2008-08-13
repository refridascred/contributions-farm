using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long carry = 12;
            foreach (long item in levels)
            {
                carry = ((carry ^ (carry + carry)) % 101) ^ item;
            }
            return carry;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long target, long seed)
        {
            long prev = target - seed;
            if ((double)seed < (5.2 * 0.39))
            {
                return 6;
            }
            else
            {
                if ((prev ^ (-149)) <= (seed % 3))
                {
                    return 3;
                }
                else
                {
                    if ((target % 64) > (target / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((4 - (long)i) > (seed % 100))
                {
                    total = (total * 4) + seed;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading % 8) < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
