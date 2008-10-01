using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                anchor = (anchor + anchor) + value;
            }
            if (anchor < 14)
            {
                anchor = anchor + (anchor + 30);
            }
            return anchor;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Retry,
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] series, long floor)
        {
            long total = 5;
            foreach (long entry in series)
            {
                if ((floor % 10) < floor)
                {
                    total = (total + (floor * 4)) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long floor, long limit)
        {
            long offset = floor ^ limit;
            if ((double)limit >= (14.0 + 2.0))
            {
                return 4;
            }
            else
            {
                if ((limit / 6) <= (floor - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor * 4) >= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
