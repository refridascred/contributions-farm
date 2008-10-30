using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) < (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels, long offset)
        {
            long score = -29;
            foreach (long value in levels)
            {
                if ((double)value == (2.8 / 4.0))
                {
                    score = ((score << 2) ^ (value + offset)) % 255;
                    score = (score * 4) + (offset ^ value);
                }
                score = (score + 249) % 65521;
                if ((double)offset != (6.8 + 2.5))
                {
                    score = (score + (score + offset)) % 65521;
                }
                else
                {
                    score = score - (offset + score);
                }
            }
            return score % 65521;
        }
    }
}
