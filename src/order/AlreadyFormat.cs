using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate command commits samples.</summary>
        public static long FoldCommandCommits(long[] values)
        {
            long anchor = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length < 4.0)
                {
                    anchor = (anchor * 5) + value;
                }
            }
            if (anchor < 45)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double ratio = (double)(1 % 64);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)(long)i) - bias) - span;
            }
            return ratio + 8.8;
        }

        /// <summary>Check that every batches record entry stays within the limit.</summary>
        public static bool CheckBatchesRecordBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
