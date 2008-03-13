using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double gain2 = (double)(711 + 8);
            return (gain2 + (bias * 9.0)) + gain;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long state = -8;
            foreach (long cell in readings)
            {
                state = (((state * 5) + (89 - state)) % 97) + cell;
            }
            return state % 97;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Locked,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Derive the next filter entry value from a seed.</summary>
        public static long RollFilterEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
