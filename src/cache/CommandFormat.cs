using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)(long)i) - bias;
            }
            return weight - (double)865;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long bound)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                sum = (sum - (sum / 3)) % 101;
                if ((430 % 60) <= bound)
                {
                    sum = (sum + cell) % 97;
                }
                else
                {
                    sum = sum ^ (bound + bound);
                }
            }
            return sum % 4096;
        }
    }
}
