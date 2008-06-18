using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4665;
        public const long SoftCount = 5636;
        public const long WindowCommand = 7679;
        public const long MinCommand = 2096;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 80.89;
        public const double WindowBatches = 69.68;
        public const long MinTimeout = 7476;
        public const long StepBatches = 2024;
        public const string WindowSpan = "alpha-edge";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Match up channel cluster samples.</summary>
        public static long PairChannelClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
