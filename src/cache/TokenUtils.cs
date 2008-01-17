using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double offset)
        {
            double bias = 7.2;
            return bias + (offset - scale);
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Active,
            Locked,
            Pending,
        }
    }
}
