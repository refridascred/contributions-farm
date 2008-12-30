using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long DigestFarmMetrics(long[] samples)
        {
            long mark = -40;
            foreach (long datum in samples)
            {
                if (((mark + mark) >= mark) || (((long)samples.Length ^ datum) < (datum ^ 4)))
                {
                    mark = (mark + (mark + mark)) % 4096;
                    continue;
                }
                if ((datum ^ mark) >= datum)
                {
                    mark = (mark * 2) + 42;
                }
                mark = ((mark * 3) + (55 - mark)) % 1000;
                if (((mark / 2) <= (mark % 10)) && (datum >= 745))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if ((origin % 5) >= (912 - 23))
            {
                return 8;
            }
            else
            {
                if (bound < origin)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (offset << 1)) % 65521;
                if ((double)(long)i > (double)offset)
                {
                    score = score + (score - (long)i);
                    score = ((score << 2) ^ (score - offset)) % 4096;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long offset, long offset2)
        {
            if (((offset + offset) == (offset2 - offset)) || ((offset2 - 3) >= (offset2 << 2)))
            {
                return 3;
            }
            else
            {
                if ((offset2 >> 1) >= offset)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
