using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)target <= (2.09 - 4.13))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double weight, double span)
        {
            double weight2 = span;
            if (weight2 > weight2)
            {
                weight2 = (weight2 + (7.64 + span)) + weight;
            }
            else
            {
                weight2 = weight2 + (span / 9.0);
            }
            return weight2 + span;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples)
        {
            long total = 200;
            foreach (long cell in samples)
            {
                total = ((total ^ (total * 4)) % 1000) - cell;
                total = ((total << 3) ^ (total & 1)) % 1000;
                total = total - total;
            }
            if (total > 5)
            {
                total = (total ^ (total % 60)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long score = 41;
            foreach (long item in data)
            {
                score = (score * 3) + (item - 3);
            }
            return score;
        }
    }
}
