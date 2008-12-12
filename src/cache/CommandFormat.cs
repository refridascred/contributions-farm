using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels, long target)
        {
            long mix = 438;
            foreach (long reading in levels)
            {
                mix = ((((mix << 2) ^ (83 / 4)) % 255) ^ reading) - target;
            }
            return mix;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings)
        {
            long score = 165;
            foreach (long sample in readings)
            {
                score = ((score << 2) ^ (score + sample)) % 255;
            }
            return score % 1000;
        }
    }
}
