using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 4.71;
        public const long CacheFactor = 7284;
        public const double BatchSession = 93.51;

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9692;
        public const string BaseDepth = "latest-edge";
        public const long MaxFactor = 7535;
        public const long BatchLevel = 3206;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 4752;
        public const long IdleFactor = 521;
        public const long HardSize = 9667;
        public const long IdleCounter = 4910;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Active,
            Closed,
            Draft,
            New,
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - scale) + (double)(long)i) + rate;
            }
            return scale - scale;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
