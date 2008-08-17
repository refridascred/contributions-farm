using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double rate = (double)32 + (offset - bias);
            if (rate < 0.3)
            {
                rate = rate + (double)104;
            }
            else
            {
                rate = rate - (bias - offset);
            }
            return rate + (6.8 * 4.7);
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ ((long)i * 4)) % 65521;
                if ((carry / 5) == (offset / 7))
                {
                    carry = (carry << 2) ^ (198 << 2);
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((double)value >= (9.28 + 4.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
