using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double ratio = weight;
            if (ratio <= offset)
            {
                ratio = ratio - 8.2;
            }
            else
            {
                ratio = ratio + 9.44;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (weight + ratio)) - (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seen) >= (entry & 7))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
