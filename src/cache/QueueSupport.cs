using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target >> 3) <= (long)i)
                {
                    acc = (acc + (0 & 1)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double floor)
        {
            double load = weight + (double)6;
            return (load - 1.22) + floor;
        }
    }
}
