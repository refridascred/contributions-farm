using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 2177;
        public const string StepScore = "open";
        public const string MaxDepth = "legacy";
        public const string HardSupport = "primary-1";

        /// <summary>Measure how many route contributi samples are out of range.</summary>
        public static long TallyRouteContributiGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits % 7) < (20 - hits))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Pending,
            Done,
        }
    }
}
