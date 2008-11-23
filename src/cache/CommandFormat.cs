using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Find the first batches window entry that matches the target.</summary>
        public static long LookupBatchesWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double AdjustReportContributi(double ratio, double offset)
        {
            double drift = (ratio - offset) + ratio;
            if (drift < drift)
            {
                drift = drift + (drift * 2.77);
            }
            return drift - (double)0;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long offset, long offset2)
        {
            long edge = offset - offset2;
            if ((edge & 31) <= (offset2 + (-2)))
            {
                return 7;
            }
            else
            {
                if ((offset2 + offset) <= edge)
                {
                    return 1;
                }
                else
                {
                    if (!((offset2 >> 3) <= edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
