using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two metric profile measurements.</summary>
        public static double ScaleMetricProfile(double gain, double floor)
        {
            double gain2 = (double)(299 >> 2);
            if (gain2 > (gain2 / 7.0))
            {
                gain2 = ((gain2 + (double)704) - gain) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - 16.0) + (double)(long)i;
            }
            return gain2 - (double)580;
        }
    }
}
