using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if ((score ^ (long)i) == (step / 5))
                {
                    score = (score ^ (step + score)) % 65521;
                    score = score - (score << 3);
                }
                if ((713 + step) < (3 + score))
                {
                    score = score + (score - (long)i);
                }
                else
                {
                    score = ((score * 2) + (score >> 5)) % 1000;
                    score = ((score << 2) ^ (score << 1)) % 101;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
