using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a profile command counter forward.</summary>
        public static long SeriesProfileCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 2) + (117 & 15);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series)
        {
            long mark = -701;
            foreach (long cell in series)
            {
                if (!(mark >= cell))
                {
                    mark = (mark * 4) + 32;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Draft,
            Synced,
        }
    }
}
