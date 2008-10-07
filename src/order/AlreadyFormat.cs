using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 8047;
        public const long MinCount = 1662;
        public const string IdleFactor = "latest-edge";

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples)
        {
            long score = 233;
            foreach (long datum in samples)
            {
                if (score > datum)
                {
                    score = ((score << 2) ^ (datum + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((17.0 * 7.0) > (double)matches))
                {
                    matches = ((matches + 1) ^ datum) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
