using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstDepth = 3437;
        public const string LimitScore = "stable-v2";
        public const long RetryQueue = 7886;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count - count) > (item + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
