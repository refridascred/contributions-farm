using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor ^ (anchor * 4)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer layout readings.</summary>
        public static long FoldBufferLayout(long[] levels)
        {
            long anchor = 98;
            foreach (long item in levels)
            {
                anchor = (((anchor * 4) + (82 & 3)) % 1000) + item;
            }
            if (anchor > (-6))
            {
                anchor = (anchor ^ (-49)) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (73 - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
