using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long bound)
        {
            long sum = 75;
            foreach (long value in readings)
            {
                sum = ((sum ^ (sum ^ sum)) ^ value) - bound;
            }
            return sum;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 6) <= reading)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long bound)
        {
            if (target <= (752 ^ bound))
            {
                return 8;
            }
            else
            {
                if (!((bound << 3) <= (target - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((2.2 * 20.0) < (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
