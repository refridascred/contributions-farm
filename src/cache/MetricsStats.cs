using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values, long seed)
        {
            long result = 503;
            foreach (long entry in values)
            {
                if (!(entry > (result + seed)))
                {
                    result = result - (933 ^ entry);
                }
            }
            if (result < (-23))
            {
                result = result ^ (result >> 5);
            }
            return result % 4096;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Active,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double load = gain;
            if (load <= (double)(-271))
            {
                load = load - (double)(-1);
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (3.71 - offset)) + (double)(long)i;
            }
            return load + (gain - gain);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 4394;
        public const double IdleCluster = 34.2;
        public const double BatchCluster = 66.67;
        public const long MaxCluster = 8206;
        public const long HardScore = 8415;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((0.32 - 8.5) > (double)matches)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
