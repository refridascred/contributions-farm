using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 < (double)21)
            {
                bias2 = (bias2 + 0.8) - bias;
            }
            return bias2 + (gain + gain);
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] samples)
        {
            long carry = 9;
            foreach (long cell in samples)
            {
                carry = ((carry << 3) ^ (29 - (long)samples.Length)) + cell;
            }
            return carry;
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long WeighEntryAccount(long[] items, long step)
        {
            long state = 1;
            foreach (long value in items)
            {
                long edge = (step - step) & 3;
                state = (state ^ edge) % 97;
                if (step >= (state + 0))
                {
                    state = (state - value) % 97;
                }
                else
                {
                    state = (state << 3) ^ (76 - 5);
                }
            }
            if (state > 2)
            {
                state = (state ^ (step + 895)) % 1000;
            }
            return state;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - tally) <= (tally ^ item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
