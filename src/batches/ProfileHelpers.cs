using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long TallyRecordCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count * 3) < count)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryFactor = "open-edge";
        public const long RetryEntry = 2128;
        public const long DefaultDepth = 8429;
        public const string BaseEntry = "open";
        public const long BatchInterval = 1209;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((97 + limit) > (limit % 10))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] series, long target)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = ((mark << 3) ^ cell) - target;
            }
            return mark % 1000;
        }
    }
}
