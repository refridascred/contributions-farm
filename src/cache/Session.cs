using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleInterval = 20.58;
        public const long MaxCommits = 4600;
        public const string BurstInterval = "staging";
        public const string HardCommits = "fallback-edge";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((50 + value) < (46 - value)) || ((double)value == (5.0 / 7.0))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc * 5) + 1;
                if (((seed + acc) >= acc) || ((acc + seed) <= acc))
                {
                    acc = (acc ^ (3 - seed)) % 1000;
                }
                else
                {
                    acc = (acc ^ (seed >> 3)) % 255;
                }
                acc = (acc - (seed * 2)) % 65521;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Queued,
            Ready,
        }
    }
}
