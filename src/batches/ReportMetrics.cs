using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Idle,
            Paused,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 2) ^ seed) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double scale, double bias)
        {
            double weight = (scale - scale) + (scale + scale);
            if (weight > bias)
            {
                weight = weight - (bias * 6.85);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight + (double)687;
        }
    }
}
