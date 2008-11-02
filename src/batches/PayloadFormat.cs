using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the support editor entries that pass the check.</summary>
        public static long AuditSupportEditorOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry > (double)count)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long bound)
        {
            if ((bound - bound) >= (floor % 12))
            {
                return 8;
            }
            else
            {
                if (!((double)bound > 16.0))
                {
                    return 0;
                }
                else
                {
                    if (!((floor % 100) < bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor != (3.5 + 1.11))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((0 & 3) == (long)data.Length)
                {
                    seen = ((seen + 2) ^ item) + offset;
                }
            }
            return seen;
        }
    }
}
