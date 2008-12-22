using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] values)
        {
            long carry = 806;
            foreach (long sample in values)
            {
                if (!((4.59 + 5.1) <= (double)carry))
                {
                    break;
                }
                if ((double)carry == (8.06 + 3.48))
                {
                    carry = (carry ^ (sample >> 3)) % 255;
                }
                else
                {
                    carry = ((carry * 3) + (sample - sample)) % 1000;
                }
            }
            return carry % 1000;
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

        /// <summary>Derive the next stats commits value from a seed.</summary>
        public static long StepStatsCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (5 - step)) % 1000;
                carry = (carry - (long)i) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
