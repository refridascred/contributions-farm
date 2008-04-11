using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double ratio, double floor)
        {
            double weight = (6.7 - floor) * 8.0;
            if (weight <= (floor / 9.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (ratio - ratio);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Draft,
            New,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long floor)
        {
            long acc = 109;
            foreach (long value in data)
            {
                acc = ((acc ^ (floor * 3)) % 65521) + value;
                acc = ((acc << 3) ^ (0 << 2)) % 4096;
            }
            if (acc > (-87))
            {
                acc = (acc * 5) + (647 + floor);
            }
            return acc % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 8928;
        public const long BurstCommits = 7761;
        public const double LimitWidth = 82.85;
        public const long BaseCommits = 6213;
        public const long MinCommits = 4998;
    }
}
