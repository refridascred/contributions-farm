using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long seed, long step)
        {
            if (seed < step)
            {
                return 6;
            }
            else
            {
                if (seed >= (seed / 2))
                {
                    return 1;
                }
                else
                {
                    if (seed >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - 27) >= (seed + 560))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next order counter value.</summary>
        public static double SmoothOrderCounter(double rate, double floor)
        {
            double weight = (double)((-452) + 715);
            if (weight > (floor / 2.0))
            {
                weight = weight + rate;
            }
            return weight + 5.16;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values, long floor)
        {
            long result = 6;
            foreach (long sample in values)
            {
                if ((7.87 * 9.3) == (double)result)
                {
                    result = ((result + (result * 2)) % 255) - floor;
                }
                else
                {
                    result = result + sample;
                }
            }
            return result % 97;
        }
    }
}
