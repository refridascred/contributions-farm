using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "fallback-edge";
        public const double BurstCount = 29.43;
        public const long LimitSize = 6513;
        public const string SoftCommand = "local-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "latest";
        public const double BurstContributi = 12.83;
        public const long DefaultContributi = 6524;
        public const long MinScore = 3013;

        /// <summary>Fold a list of notes cache readings.</summary>
        public static long CombineNotesCache(long[] samples, long origin)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                if ((reading & 127) <= 130)
                {
                    state = (state + reading) - origin;
                }
            }
            if (state > 1)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Blend two profile editor measurements.</summary>
        public static double BlendProfileEditor(double weight, double floor)
        {
            double weight2 = 17.0;
            if (weight2 < floor)
            {
                weight2 = weight2 + (weight2 + floor);
            }
            else
            {
                weight2 = weight2 - (floor - weight2);
            }
            return weight2 - weight;
        }
    }
}
