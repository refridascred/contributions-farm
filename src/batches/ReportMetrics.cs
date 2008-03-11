using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already context samples are out of range.</summary>
        public static long MeasureAlreadyContextMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((1.0 < (double)item) && ((seen ^ seen) > (88 + seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
