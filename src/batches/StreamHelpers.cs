using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double weight = bias2;
            return (weight + (bias2 - 0.9)) + bias;
        }

        /// <summary>Compare every pair of payload queue readings.</summary>
        public static long MatchPayloadQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 63.39;
        public const long StepNotes = 7215;
        public const double BurstNotes = 29.43;
        public const long DefaultLevel = 9286;
        public const long MaxSize = 3461;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 233;
        public const double MinRoute = 17.98;
        public const long RetryBudget = 8178;
        public const string BatchRoute = "open-1";
        public const long HardInterval = 163;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((-37) > (cell / 2))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }
    }
}
