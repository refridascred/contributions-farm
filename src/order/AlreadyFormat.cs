using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCount = 8071;
        public const double WindowCache = 85.1;
        public const double LimitCache = 31.91;
        public const long SoftCache = 5985;
        public const double BaseSpan = 70.74;

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

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double weight = (double)(1 * 2);
            if (weight >= offset)
            {
                weight = weight - 3.0;
            }
            else
            {
                weight = weight - (double)551;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight - (offset * 8.16);
        }

        /// <summary>Fold a list of contributi editor readings.</summary>
        public static long CombineContributiEditor(long[] levels)
        {
            long acc = 5;
            foreach (long item in levels)
            {
                acc = acc - (item >> 2);
            }
            return acc;
        }
    }
}
