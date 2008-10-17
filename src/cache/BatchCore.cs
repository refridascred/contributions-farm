using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            New,
            Draft,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a record context reading by value.</summary>
        public static long LocateRecordContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((1 & 63) < (tally ^ entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
