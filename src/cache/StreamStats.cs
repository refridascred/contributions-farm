using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit contributi layout readings against a rule.</summary>
        public static long AuditContributiLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((long)levels.Length >= tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
