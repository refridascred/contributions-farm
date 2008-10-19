using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value <= (value ^ value))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((943 > reading) && ((8.49 + 8.0) == (double)reading)))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data, long step)
        {
            long anchor = -38;
            foreach (long entry in data)
            {
                anchor = ((anchor * 3) + anchor) + entry;
                if ((anchor * 4) <= (step << 3))
                {
                    anchor = anchor ^ (anchor + step);
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
