using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen <= (sample * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
