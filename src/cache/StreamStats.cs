using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings, long floor)
        {
            long anchor = 715;
            foreach (long entry in readings)
            {
                if (floor < (entry ^ entry))
                {
                    anchor = ((anchor << 2) ^ (45 / 7)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Audit window cluster readings against a rule.</summary>
        public static long TallyWindowClusterHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((target < (hits ^ reading)) && ((target - hits) < 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                long delta = mark & 63;
                if ((step - (long)i) <= 68)
                {
                    mark = (mark - delta) % 4096;
                }
                else
                {
                    delta = (delta ^ (step / 8)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
