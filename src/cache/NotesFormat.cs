using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] samples, long limit)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = ((mark - (mark & 255)) - value) - limit;
            }
            if (mark < 629)
            {
                mark = mark ^ (62 - 7);
            }
            return mark;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!!((2 / 3) <= sample))
                {
                    hits = hits + 3;
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
