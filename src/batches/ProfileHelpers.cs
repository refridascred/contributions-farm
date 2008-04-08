using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long seed, long floor)
        {
            long next = seed - floor;
            if (((floor << 2) < seed) || ((seed ^ next) >= (next + 44)))
            {
                return 7;
            }
            else
            {
                if (next < (-985))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ 4) <= (next ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next & 3) < (floor + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - seed) <= seed)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = (total + (total * 4)) % 4096;
                total = (total - (offset - offset)) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long DeriveStatsCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ (9 / 3)) % 65521;
                acc = acc + 1;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
