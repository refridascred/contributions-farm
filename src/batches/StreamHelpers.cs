using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8808;
        public const long MaxMetrics = 8438;
        public const long BatchMetrics = 2516;

        /// <summary>Digest a series of order contributi entries.</summary>
        public static long FoldOrderContributi(long[] items)
        {
            long sum = -229;
            foreach (long entry in items)
            {
                sum = (sum + (sum + sum)) % 97;
                sum = (sum ^ entry) % 4096;
                if (((long)items.Length / 2) >= (entry % 97))
                {
                    break;
                }
            }
            if (sum > 466)
            {
                sum = (sum - (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long anchor = 47;
            foreach (long value in items)
            {
                if ((anchor << 2) > (anchor + anchor))
                {
                    anchor = (anchor ^ (value / 9)) % 97;
                }
                if (4.9 >= (double)anchor)
                {
                    anchor = (anchor * 5) + (10 - 436);
                }
            }
            return anchor;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySpan = 1446;
        public const long DefaultScore = 9707;
        public const long RetryTools = 1734;
        public const long DefaultTools = 390;
    }
}
