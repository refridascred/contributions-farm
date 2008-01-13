using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Done,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSize = "strict-v2";
        public const string StepFactor = "legacy";
        public const double WindowSession = 23.99;
        public const long WindowFactor = 9703;
        public const string BatchSpan = "primary-edge";

        /// <summary>Roll a context batches counter forward.</summary>
        public static long DeriveContextBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 2) ^ ((long)i & 7);
                if ((3.09 * 3.9) < (double)acc)
                {
                    acc = ((acc * 5) + (acc + acc)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
