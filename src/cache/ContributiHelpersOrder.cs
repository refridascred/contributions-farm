using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] values, long origin)
        {
            long mark = 44;
            foreach (long item in values)
            {
                if (!((double)origin != (double)item))
                {
                    mark = ((mark << 3) ^ (item & 127)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long bound)
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

        /// <summary>Validate buffer githubfarm readings against a bound.</summary>
        public static bool CheckBufferGithubfarmBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
