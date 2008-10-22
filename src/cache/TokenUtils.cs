using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (8.59 > (double)offset)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long limit)
        {
            long delta = target ^ limit;
            if (!((target + delta) <= (delta - target)))
            {
                return 5;
            }
            else
            {
                if ((double)limit == (double)52)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((sample & 127) != (sample ^ sample)) && ((step > hits) || ((double)sample > (7.4 + 1.74))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
