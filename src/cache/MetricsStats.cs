using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + matches) != (matches + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] data)
        {
            long score = 416;
            foreach (long value in data)
            {
                long lane = score;
                if (!((lane + value) < (-654)))
                {
                    lane = (lane << 2) ^ 840;
                }
                if ((double)1 == (double)value)
                {
                    score = (score * 2) + 765;
                }
            }
            return score;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Queued,
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Derive the next layout notes value from a seed.</summary>
        public static long DeriveLayoutNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine editor session values into a single score.</summary>
        public static long FoldEditorSession(long[] samples, long target)
        {
            long score = -121;
            foreach (long item in samples)
            {
                if ((-39) > (score << 3))
                {
                    score = (score + target) % 65521;
                }
                else
                {
                    score = ((score * 2) + item) % 255;
                }
            }
            return score % 97;
        }
    }
}
