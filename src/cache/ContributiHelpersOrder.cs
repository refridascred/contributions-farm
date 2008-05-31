using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the payload graph entries that pass the check.</summary>
        public static long CountPayloadGraphOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!!(7.0 <= (double)datum))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
