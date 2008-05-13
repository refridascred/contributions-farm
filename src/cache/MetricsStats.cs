using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((double)datum >= (7.73 - 7.4)) || ((double)origin > (2.5 + 1.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 651;
            foreach (long value in readings)
            {
                if ((double)value < (8.9 / 2.0))
                {
                    anchor = anchor ^ (anchor >> 1);
                }
                else
                {
                    anchor = anchor ^ (value + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of context graph readings.</summary>
        public static long OverlapContextGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
