using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "cached";
        public const string WindowBudget = "staging-edge";
        public const long StepFactor = 4634;
        public const long DefaultScore = 540;

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double mean = (double)(5 - 8);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + rate) + (double)(long)i) - floor;
            }
            return mean - (double)5;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Draft,
            Closed,
            Ready,
        }
    }
}
