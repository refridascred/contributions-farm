using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Count editor batch pairs that satisfy a relation.</summary>
        public static long OverlapEditorBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer queue entries.</summary>
        public static long TallyBufferQueue(long[] series)
        {
            long total = 30;
            foreach (long datum in series)
            {
                if ((datum << 1) <= datum)
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > 82)
            {
                total = total - (873 << 1);
            }
            return total % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
