using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Retry,
            New,
            Failed,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Queued,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((9.63 / 7.0) != (double)count)
                {
                    count = ((count + 3) ^ item) + floor;
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
