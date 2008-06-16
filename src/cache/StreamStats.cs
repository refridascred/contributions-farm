using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit format order readings against a rule.</summary>
        public static long MeasureFormatOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 2) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long carry = 65;
            foreach (long cell in data)
            {
                if ((12 & 1) < (cell << 1))
                {
                    carry = carry ^ (bound + cell);
                }
                else
                {
                    carry = ((carry << 2) ^ (long)data.Length) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits < (offset - hits))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
