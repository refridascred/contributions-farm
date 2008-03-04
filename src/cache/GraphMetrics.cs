using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 9797;
        public const long DefaultInterval = 9130;
        public const long BaseEditor = 1895;
        public const long StepEditor = 7585;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Closed,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double mean = bias;
            return mean + (ratio + 3.1);
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally > (sample * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
