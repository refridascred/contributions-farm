using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - datum)) % 4096;
                if (!((7 & 255) <= (datum / 8)))
                {
                    sum = ((sum << 3) ^ (414 + sum)) % 101;
                }
                else
                {
                    sum = (sum + (1 - 50)) % 4096;
                }
            }
            if (sum < 720)
            {
                sum = ((sum * 2) + sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
