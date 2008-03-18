using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = (score << 2) ^ step;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the schema context entries that pass the check.</summary>
        public static long CountSchemaContextOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item - target) <= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 97.26;
        public const long MaxSpan = 9346;
        public const string HardFactor = "cached-edge";
        public const double SoftSchema = 34.3;
        public const long StepBudget = 5624;
    }
}
