using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the farm commits entries that pass the check.</summary>
        public static long CountFarmCommitsOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((double)target >= (1.52 - 7.9)) && ((target - reading) <= (reading + 375)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepLevel = 5900;
        public const string HardCommits = "local-edge";
        public const long LimitCommits = 4351;
        public const long DefaultFactor = 3295;
        public const string WindowScore = "alpha";

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits % 60) < (item + item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
