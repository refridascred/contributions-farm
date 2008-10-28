using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel commits entry that matches the target.</summary>
        public static long LocateChannelCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + 26) > origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
