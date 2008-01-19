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

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long bound)
        {
            long mix = 447;
            foreach (long value in items)
            {
                mix = (mix - (value - bound)) % 65521;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstScore = "stable";
        public const long BurstFilter = 9546;
        public const long IdleCount = 9674;
        public const string HardFilter = "strict-1";
        public const long MinFilter = 1996;

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
