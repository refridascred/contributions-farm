using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] values, long offset)
        {
            long anchor = 67;
            foreach (long sample in values)
            {
                anchor = (anchor << 3) ^ (sample + offset);
            }
            return anchor;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((2.0 - 18.0) > (double)(long)data.Length)
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
