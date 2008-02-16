using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count < ((-25) / 5)) || (((count & 127) <= (count / 4)) || (entry <= (count - entry))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long MeasureProfileCacheOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((count & 3) > (reading - reading)) && (count >= (count ^ 433))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next context profile value from a seed.</summary>
        public static long IterateContextProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (seed - mark)) % 4096;
                mark = mark + (mark * 4);
                mark = mark - (-49);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the notes tools entries that pass the check.</summary>
        public static long MeasureNotesToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (reading - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
