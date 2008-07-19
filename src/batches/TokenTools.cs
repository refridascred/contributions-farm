using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine command stream values into a single score.</summary>
        public static long TallyCommandStream(long[] readings)
        {
            long anchor = 364;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ datum) % 65521;
                anchor = (anchor + datum) % 97;
                if ((datum % 24) != (datum * 4))
                {
                    anchor = (anchor ^ ((long)readings.Length - datum)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((offset % 12) >= (limit ^ offset2))
            {
                return 0;
            }
            else
            {
                if (offset >= (limit * 4))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 * 2) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
