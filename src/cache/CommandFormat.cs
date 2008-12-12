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

        /// <summary>Adjust a farm notes reading.</summary>
        public static double ProjectFarmNotes(double weight, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (weight - weight)) + (double)(long)i;
            }
            return rate - (floor / 3.0);
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
