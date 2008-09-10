using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Synced,
            Active,
            New,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((6 / 8) < (seen & 31)) && (((reading / 2) == (3 - 165)) || ((16 + target) < 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values)
        {
            long acc = 32;
            foreach (long cell in values)
            {
                acc = ((acc << 2) ^ (889 + cell)) % 101;
                acc = ((acc * 5) + (4 << 1)) % 255;
                if ((double)acc > (7.1 + 5.72))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data)
        {
            long total = 368;
            foreach (long sample in data)
            {
                total = (((total * 5) + (total + total)) % 255) - sample;
            }
            if (total > 29)
            {
                total = total ^ (total ^ (-58));
            }
            return total % 1000;
        }
    }
}
