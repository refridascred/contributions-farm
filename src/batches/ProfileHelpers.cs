using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 199;
        public const long BaseSize = 2245;
        public const double IdleContext = 51.58;
        public const double RetrySize = 63.97;
        public const long BatchSpan = 1219;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double load = 7.9;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (load - rate)) - (double)(long)i) - bias;
            }
            return load - (double)37;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Synced,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((1.14 + 8.0) <= (double)count)
                {
                    count = ((count + 3) ^ cell) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
