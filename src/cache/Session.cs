using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Active,
            Draft,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Draft,
            Idle,
            Paused,
            Ready,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double rate = (double)(0 << 2);
            if (rate < (1.1 + 7.1))
            {
                rate = ((rate + 7.0) + gain) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 12.0) + (double)(long)i;
            }
            return rate - (double)54;
        }
    }
}
