using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double mean = 18.0 * 0.82;
            if (mean >= (span - 9.79))
            {
                mean = mean - (scale * 5.9);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean + (span - scale);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Draft,
            New,
            Paused,
            Active,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Idle,
            Draft,
            New,
        }
    }
}
