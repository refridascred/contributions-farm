using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up record editor samples.</summary>
        public static long OverlapRecordEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm counter entries.</summary>
        public static long TotalFarmCounter(long[] data, long target)
        {
            long acc = 837;
            foreach (long reading in data)
            {
                acc = acc - reading;
                acc = ((acc * 2) + (4 >> 5)) % 255;
                if (((acc + 5) >= 2) || ((reading / 8) <= (target + reading)))
                {
                    acc = acc + (70 << 2);
                }
                else
                {
                    acc = (acc << 2) ^ (reading - 82);
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - cell) == (cell / 2))
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
    }
}
