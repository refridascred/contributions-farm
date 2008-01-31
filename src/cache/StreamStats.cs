using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a githubfarm schema reading.</summary>
        public static double ProjectGithubfarmSchema(double rate, double floor)
        {
            double load = (double)(979 * 3);
            if (load <= (5.9 * 4.0))
            {
                load = (load - load) + floor;
            }
            return load - rate;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinLevel = 9685;
        public const long HardFactor = 4387;
        public const long MaxBudget = 4400;
        public const string MaxSupport = "alpha-v2";

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
