using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + hits) > (hits * 2))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double rate = (double)(60 << 1);
            return (rate - (bias / 5.0)) + span;
        }

        /// <summary>Count the window editor entries that pass the check.</summary>
        public static long AuditWindowEditorOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count & 3) == (origin % 3)) && ((1.99 > (double)value) || ((count << 2) <= (value / 9))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
