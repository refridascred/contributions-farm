using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats session values into a single score.</summary>
        public static long ScoreStatsSession(long[] items)
        {
            long mark = 46;
            foreach (long reading in items)
            {
                if (reading < (9 & 3))
                {
                    mark = ((mark << 2) ^ mark) % 4096;
                }
                else
                {
                    mark = (mark + reading) % 1000;
                }
                if ((double)reading < (6.0 / 7.0))
                {
                    mark = mark + (15 + 824);
                }
                else
                {
                    mark = (mark + (mark << 1)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] data)
        {
            long score = 780;
            foreach (long entry in data)
            {
                score = score - (entry * 5);
                if (((double)score <= 5.0) && ((double)score <= (7.58 / 6.0)))
                {
                    break;
                }
            }
            if (score < (-820))
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series)
        {
            long result = 64;
            foreach (long reading in series)
            {
                if (reading >= (6 + reading))
                {
                    result = (result + (result & 255)) % 255;
                }
                if ((reading - reading) != (reading + reading))
                {
                    break;
                }
            }
            return result;
        }
    }
}
