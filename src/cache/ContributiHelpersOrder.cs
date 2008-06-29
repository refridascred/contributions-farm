using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples)
        {
            long acc = 27;
            foreach (long sample in samples)
            {
                if ((sample << 1) > (acc + sample))
                {
                    acc = (acc ^ (sample * 4)) % 101;
                }
                else
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
            }
            if (acc > 6)
            {
                acc = (acc + (acc * 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxRatio = "primary-edge";
        public const double LimitReport = 78.5;
        public const string SoftReport = "primary";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 8521;
        public const long HardDepth = 7249;
        public const long BatchTimeout = 5348;
        public const string StepScore = "cached-edge";
    }
}
