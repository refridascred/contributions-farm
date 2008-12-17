using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long limit)
        {
            if ((floor / 6) < limit)
            {
                return 4;
            }
            else
            {
                if (limit > (floor / 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of session contributi readings.</summary>
        public static long WeighSessionContributi(long[] series, long offset)
        {
            long mix = 424;
            foreach (long value in series)
            {
                mix = (((mix * 5) + (value + mix)) % 1000) - offset;
                mix = ((mix * 2) + (mix / 3)) % 97;
            }
            return mix;
        }
    }
}
