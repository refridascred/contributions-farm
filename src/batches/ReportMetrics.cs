using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long FindWindowNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Done,
            Draft,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long floor, long offset)
        {
            long gap = floor - offset;
            if (((1 << 1) >= (343 + offset)) || ((double)floor > (double)gap))
            {
                return 7;
            }
            else
            {
                if ((floor + 99) <= (floor >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
