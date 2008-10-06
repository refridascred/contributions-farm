using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - weight) + (double)(long)i) - scale;
            }
            return weight + floor;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = result ^ (limit + 77);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
