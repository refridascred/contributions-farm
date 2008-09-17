using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next layout notes value from a seed.</summary>
        public static long SeriesLayoutNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 2) ^ (59 + offset)) ^ (long)i2;
                    result = (result << 3) ^ (offset % 5);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((limit - (-7)) == (limit << 3)) || ((2.71 * 20.0) == (double)total))
                {
                    total = total + 93;
                }
                total = (total + (600 - limit)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits > (cell + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
