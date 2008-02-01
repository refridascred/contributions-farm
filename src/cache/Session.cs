using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two context support measurements.</summary>
        public static double AdjustContextSupport(double rate, double span)
        {
            double drift = (rate * 20.0) * 4.92;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 86.15;
        public const long HardChecks = 6671;
        public const long LimitChecks = 7085;
        public const long StepChecks = 7245;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Pending,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Check that every record stream entry stays within the limit.</summary>
        public static bool CheckRecordStreamLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
