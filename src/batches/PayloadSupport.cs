using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
