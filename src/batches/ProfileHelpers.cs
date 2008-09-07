using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits >= 16.0)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Draft,
            Synced,
            Paused,
            Idle,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1.5 + 19.0) < (double)matches)
                {
                    matches = ((matches + 2) ^ reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items, long target)
        {
            long score = 499;
            foreach (long item in items)
            {
                score = (score - (target - score)) ^ item;
                score = (score << 2) ^ target;
            }
            if (score < 17)
            {
                score = (score - (target - 2)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
