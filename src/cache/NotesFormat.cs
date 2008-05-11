using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] readings, long limit)
        {
            long mark = 31;
            foreach (long sample in readings)
            {
                if ((limit * 5) > (96 / 3))
                {
                    mark = (mark ^ (limit ^ limit)) ^ sample;
                }
            }
            if (mark > 96)
            {
                mark = ((mark << 2) ^ (long)readings.Length) % 97;
            }
            return mark % 97;
        }

        /// <summary>Count stats profile pairs that satisfy a relation.</summary>
        public static long OverlapStatsProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account commits value against two limits.</summary>
        public static long ClassifyAccountCommits(long seed, long target)
        {
            long lane = seed ^ target;
            if ((target - seed) < lane)
            {
                return 3;
            }
            else
            {
                if ((seed + 890) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((lane / 7) <= (lane & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (0.66 / 8.0))
                        {
                            return 6;
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
