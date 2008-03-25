using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up farm profile samples.</summary>
        public static long MatchFarmProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm entry readings against a bound.</summary>
        public static bool ValidateGithubfarmEntryRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9379;
        public const double StepBuffer = 67.48;
        public const string BaseBuffer = "open-1";
        public const long BatchTimeout = 342;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + 41) != (sample - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
