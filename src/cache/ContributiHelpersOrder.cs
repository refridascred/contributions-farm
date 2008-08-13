using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a githubfarm format reading by value.</summary>
        public static long FindGithubfarmFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Idle,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Accumulate batches profile samples.</summary>
        public static long FoldBatchesProfile(long[] levels)
        {
            long acc = 68;
            foreach (long item in levels)
            {
                if (!((double)item < 7.7))
                {
                    acc = (acc - 1) % 101;
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ (acc & 1)) % 255;
            }
            return acc;
        }
    }
}
