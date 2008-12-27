using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of queue layout readings.</summary>
        public static long TotalQueueLayout(long[] data)
        {
            long mark = 98;
            foreach (long cell in data)
            {
                if (((cell << 2) <= (201 / 7)) || ((cell + cell) == (cell >> 5)))
                {
                    mark = mark + (mark / 2);
                }
                else
                {
                    mark = (mark - (5 + cell)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((62 ^ origin) < (661 + anchor))
                {
                    anchor = (anchor * 5) + (origin - (long)i);
                    anchor = (anchor * 5) + (origin % 97);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the notes layout entries that pass the check.</summary>
        public static long CountNotesLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 5) > (reading + reading))
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
