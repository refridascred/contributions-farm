using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a batches record sample.</summary>
        public static long SeekBatchesRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long DigestStreamFarm(long[] readings)
        {
            long sum = 359;
            foreach (long reading in readings)
            {
                if ((reading >= (sum + reading)) && ((sum + sum) < (sum >> 2)))
                {
                    sum = (sum * 4) + (reading ^ reading);
                }
                if (!((0.8 - 14.0) > (double)reading))
                {
                    break;
                }
            }
            if (sum < 23)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 97;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((718 ^ count) < (count + value)) || ((0.05 / 4.0) < (double)(long)series.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
