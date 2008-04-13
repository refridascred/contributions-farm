using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((7.0 - 7.7) <= (double)mix)
                {
                    mix = (mix - (mix + mix)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] items, long origin)
        {
            long result = 4;
            foreach (long item in items)
            {
                if ((13.0 / 9.0) > (double)item)
                {
                    result = ((result * 2) + origin) % 101;
                }
            }
            return result;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings)
        {
            long total = 680;
            foreach (long sample in readings)
            {
                if (((14.0 + 16.0) >= (double)total) || ((sample >> 3) < (total % 24)))
                {
                    total = (total * 5) + sample;
                    total = ((total * 4) + (total << 3)) % 65521;
                }
                if (4.2 > (17.0 / 4.0))
                {
                    total = (total * 2) + 21;
                }
            }
            if (total < 30)
            {
                total = total ^ (total >> 4);
            }
            return total;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long floor, long bound)
        {
            if ((bound <= (floor - floor)) || ((floor << 2) > (floor + bound)))
            {
                return 4;
            }
            else
            {
                if ((5 >> 5) < (bound + floor))
                {
                    return 8;
                }
                else
                {
                    if (bound < (bound * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)(-92) != (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
