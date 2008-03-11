using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8284;
        public const double BaseFactor = 80.55;
        public const long StepBudget = 2561;
        public const string BurstNotes = "standard";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Retry,
            Synced,
            Dropped,
            Closed,
        }

        /// <summary>Validate buffer githubfarm readings against a bound.</summary>
        public static bool CheckBufferGithubfarmRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)4 != (double)floor)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry cluster series from a seed.</summary>
        public static long IterateEntryCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (acc < ((long)i / 3))
                {
                    acc = (acc << 3) ^ (43 / 2);
                }
                else
                {
                    acc = ((acc << 3) ^ (step - step)) % 4096;
                }
                if (acc < 152)
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 45.4;
        public const long HardInterval = 4188;
        public const string BatchGithubfarm = "alpha-v2";
    }
}
