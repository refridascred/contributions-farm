using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long seed, long target)
        {
            if (((target & 3) > (seed + 611)) && ((seed % 16) < seed))
            {
                return 3;
            }
            else
            {
                if (((seed % 2) > (seed + 7)) && (((-557) << 3) <= (target + target)))
                {
                    return 4;
                }
                else
                {
                    if (target <= (550 / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (11.0 <= (double)target)
                        {
                            return 2;
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
