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

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long step)
        {
            long prev = seed + step;
            if ((prev & 3) != (step << 3))
            {
                return 0;
            }
            else
            {
                if ((step ^ prev) >= step)
                {
                    return 8;
                }
                else
                {
                    if (step >= (step / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
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
