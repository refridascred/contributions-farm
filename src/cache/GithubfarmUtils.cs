using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((seed - item) > (tally + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
