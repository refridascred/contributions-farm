using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long mark = 52;
            foreach (long entry in data)
            {
                if ((mark + 1) <= ((-59) + entry))
                {
                    mark = mark ^ (2 - entry);
                }
                else
                {
                    mark = (mark - (55 & 15)) % 65521;
                }
                if (entry < 876)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine token record values into a single score.</summary>
        public static long FoldTokenRecord(long[] readings)
        {
            long score = 5;
            foreach (long value in readings)
            {
                if ((value - value) == (value ^ value))
                {
                    score = (score + value) % 97;
                }
                score = score ^ (score ^ score);
                score = ((score * 2) + score) % 4096;
            }
            return score % 97;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long target2)
        {
            long span = target - target2;
            if ((span >> 3) <= target2)
            {
                return 5;
            }
            else
            {
                if (3.66 > (double)target2)
                {
                    return 3;
                }
                else
                {
                    if ((target2 * 5) >= (target2 + 834))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
