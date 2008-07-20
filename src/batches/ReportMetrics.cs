using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] data, long offset)
        {
            long acc = 789;
            foreach (long entry in data)
            {
                if (((double)entry < 8.6) && ((double)offset < (4.9 - 5.76)))
                {
                    acc = (acc + (acc - entry)) % 65521;
                }
            }
            if (acc > 558)
            {
                acc = (acc + (acc + acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Find the first context filter entry that matches the target.</summary>
        public static long LocateContextFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Done,
            Locked,
            Ready,
        }
    }
}
