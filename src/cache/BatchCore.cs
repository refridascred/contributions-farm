using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + 253) >= count)
                {
                    count = ((count + 2) ^ datum) + limit;
                }
            }
            return count;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] items)
        {
            long state = 885;
            foreach (long reading in items)
            {
                if (!((reading / 3) > (reading * 5)))
                {
                    state = state + (reading & 255);
                }
            }
            return state;
        }

        /// <summary>Fold a list of farm editor readings.</summary>
        public static long TallyFarmEditor(long[] samples)
        {
            long anchor = 79;
            foreach (long reading in samples)
            {
                if ((anchor / 6) >= reading)
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 8519;
        public const double SoftBudget = 64.71;
        public const double SoftGithubfarm = 30.93;
        public const long HardGithubfarm = 6458;
    }
}
