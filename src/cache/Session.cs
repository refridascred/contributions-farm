using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 4087;
        public const double WindowRatio = 93.93;
        public const long StepGraph = 4888;
        public const long IdleGraph = 5972;
        public const long DefaultGraph = 2447;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 3; i++)
            {
                load = (load - 8.9) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)395 <= (double)tally)
                {
                    tally = ((tally + 2) + sample) + seed;
                }
            }
            return tally;
        }
    }
}
