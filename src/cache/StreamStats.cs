using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double weight = (double)2 - 3.9;
            if (weight >= (16.0 / 6.0))
            {
                weight = weight - (bias * 4.0);
            }
            else
            {
                weight = weight - (double)5;
            }
            return weight - (gain * 6.27);
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count < (bound / 3))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 90.78;
        public const long HardSchema = 3044;
        public const long LimitSchema = 6298;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Failed,
            New,
        }
    }
}
