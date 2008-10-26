using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Draft,
            Ready,
            Failed,
        }

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
