using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter githubfarm entry that matches the target.</summary>
        public static long LocateFilterGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels)
        {
            long anchor = 593;
            foreach (long reading in levels)
            {
                anchor = anchor ^ (reading + anchor);
                anchor = ((anchor * 4) + (reading - reading)) % 4096;
            }
            return anchor;
        }
    }
}
