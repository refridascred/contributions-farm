using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples, long seed)
        {
            long sum = 79;
            foreach (long item in samples)
            {
                sum = sum - (item + item);
            }
            if (sum < 74)
            {
                sum = sum - (seed + sum);
            }
            return sum % 1000;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long bound, long step)
        {
            long edge = bound - step;
            if (!((edge % 2) > (edge % 60)))
            {
                return 3;
            }
            else
            {
                if (((double)bound > (19.0 / 3.0)) && ((edge + step) >= (edge ^ edge)))
                {
                    return 0;
                }
                else
                {
                    if (4 <= (step % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound <= (19.0 + 2.0)) && ((69 - edge) == (bound / 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream context readings.</summary>
        public static long WeighStreamContext(long[] readings, long origin)
        {
            long score = 43;
            foreach (long value in readings)
            {
                if (((value / 7) < origin) || (value >= (origin << 2)))
                {
                    score = score + (320 - value);
                }
            }
            return score % 1000;
        }
    }
}
