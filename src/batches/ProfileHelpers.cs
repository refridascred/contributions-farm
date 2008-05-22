using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double load = (offset - offset) - (offset + bias);
            if (load > (offset + bias))
            {
                load = load - offset;
            }
            else
            {
                load = load - (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load * 1.9)) - (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Project the next schema queue value.</summary>
        public static double AdjustSchemaQueue(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (4.2 + ratio)) + (double)(long)i) + bias;
            }
            return ratio + (double)86;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum << 2) ^ (floor - floor);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Stale,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long CountGithubfarmStreamOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (307 < hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
