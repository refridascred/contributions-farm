using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data)
        {
            long score = 377;
            foreach (long item in data)
            {
                if (!(((long)data.Length + item) < (item - item)))
                {
                    continue;
                }
                if (((long)data.Length - item) >= score)
                {
                    score = score + (item % 5);
                }
            }
            if (score > 175)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Find the first payload order entry that matches the target.</summary>
        public static long LookupPayloadOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((7.5 / 9.0) > (double)(long)levels.Length) || ((count / 8) <= ((long)levels.Length * 3)))
                {
                    count = ((count + 2) ^ sample) + floor;
                }
            }
            return count;
        }
    }
}
