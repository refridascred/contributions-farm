using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support entry entries that pass the check.</summary>
        public static long CountSupportEntryOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell >= (long)samples.Length)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] data)
        {
            long result = 13;
            foreach (long value in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result + (result - 4)) % 101) + (long)i;
                }
                result = (result + (result / 3)) % 4096;
                if ((result + (long)data.Length) < (result % 8))
                {
                    result = (result + (value ^ result)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
