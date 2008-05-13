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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits <= (sample + sample))
                {
                    hits = hits + 1;
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
