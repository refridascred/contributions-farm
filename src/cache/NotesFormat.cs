using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitCount = 1801;
        public const long DefaultAlready = 7596;
        public const long MaxAlready = 1479;
        public const string SoftAlready = "latest-edge";
        public const long HardBudget = 6004;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long bound)
        {
            long lane = offset - bound;
            if (((bound + offset) <= (8 ^ bound)) || ((3 / 8) <= (lane ^ lane)))
            {
                return 5;
            }
            else
            {
                if ((8.2 / 7.0) == (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (346 < lane)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Pending,
            Retry,
            Locked,
        }
    }
}
