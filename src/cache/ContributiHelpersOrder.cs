using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i ^ step)) ^ (long)i2;
                }
                if ((90 < (step & 15)) || ((3 & 7) == (carry + carry)))
                {
                    carry = (carry - (carry - carry)) % 101;
                }
                else
                {
                    carry = (carry - (step + (long)i)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long TallySupportCommandHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((count + value) < floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches <= (0.17 / 7.0))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
