using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double offset)
        {
            double weight = 8.0 + (bias * 8.46);
            if (weight > (2.9 + weight))
            {
                weight = weight + (weight - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up already contributi samples.</summary>
        public static long PairAlreadyContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
