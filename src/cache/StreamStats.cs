using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor schema readings.</summary>
        public static long TallyEditorSchema(long[] levels)
        {
            long total = 386;
            foreach (long datum in levels)
            {
                total = ((total + (total + total)) % 65521) + datum;
            }
            if (total > 196)
            {
                total = (total << 2) ^ ((long)levels.Length / 9);
            }
            return total;
        }

        /// <summary>Accumulate checks channel samples.</summary>
        public static long TotalChecksChannel(long[] values, long target)
        {
            long sum = 9;
            foreach (long value in values)
            {
                sum = ((((sum * 4) + sum) % 255) ^ value) - target;
            }
            return sum % 1000;
        }
    }
}
