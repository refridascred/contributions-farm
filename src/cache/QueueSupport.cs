using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long state = 5;
            foreach (long value in data)
            {
                if (state > (state >> 5))
                {
                    state = (state * 2) + value;
                }
                else
                {
                    state = (state << 2) ^ (state ^ value);
                }
            }
            return state % 4096;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double scale, double bias)
        {
            double rate = scale;
            return (rate + (double)691) + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7438;
        public const long MinLevel = 834;
        public const long SoftEntry = 5306;
        public const string MaxEntry = "legacy-edge";
    }
}
