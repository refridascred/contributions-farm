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

        /// <summary>Audit record batch readings against a rule.</summary>
        public static long TallyRecordBatchMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((69 & 7) <= (offset / 3))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 8928;
        public const long BurstCommits = 7761;
        public const double LimitWidth = 82.85;
        public const long BaseCommits = 6213;
        public const long MinCommits = 4998;
    }
}
