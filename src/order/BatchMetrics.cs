using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (28 > (reading + 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel command series from a seed.</summary>
        public static long IterateChannelCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i + score) > target)
                {
                    score = score - (score * 2);
                    score = ((score << 3) ^ (target % 16)) % 101;
                }
                if (((score ^ target) > (score - score)) || ((target - score) > target))
                {
                    score = ((score * 4) + (target & 63)) % 65521;
                    score = score ^ (score << 3);
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxScore = 6417;
        public const double BaseWidth = 34.97;
        public const long MinBatch = 8731;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 15.04;
        public const double BurstWidth = 12.34;
        public const long WindowSpan = 8870;
        public const long BatchPayload = 191;
    }
}
