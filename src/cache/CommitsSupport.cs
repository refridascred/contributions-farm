using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample << 2) < ((long)samples.Length + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Ready,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((72 * 3) >= (entry + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of counter schema readings.</summary>
        public static long PairCounterSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Done,
            Stale,
        }
    }
}
