using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double bias = floor / 6.0;
            return bias + (bias - gain);
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples, long bound)
        {
            long score = 24;
            foreach (long item in samples)
            {
                score = score ^ bound;
                if ((item << 2) <= (score * 2))
                {
                    score = (score ^ (item % 60)) % 4096;
                }
            }
            if (score > (-750))
            {
                score = score + (bound + 7);
            }
            return score;
        }
    }
}
