using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = (score - (long)i) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long result = 2;
            foreach (long value in samples)
            {
                result = result ^ (result / 7);
                if ((-45) >= value)
                {
                    result = result + value;
                }
            }
            return result % 65521;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double rate = (double)7 / 9.0;
            if (rate <= (weight / 7.0))
            {
                rate = (rate - (weight / 8.0)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (weight / 8.0)) + (double)(long)i;
            }
            return rate - (rate / 6.0);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                long offset2 = offset;
                if (!((6.5 + 9.0) > (double)mix))
                {
                    long next = offset2;
                    mix = mix - (next - (long)i);
                    continue;
                }
                else
                {
                    offset2 = ((offset2 * 4) + offset2) % 4096;
                    mix = mix ^ offset2;
                }
                if ((8.41 - 1.13) < (double)offset)
                {
                    mix = mix ^ (offset2 + offset2);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
