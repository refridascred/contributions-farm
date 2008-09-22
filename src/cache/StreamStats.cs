using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseFactor = 14.47;
        public const double BurstTimeout = 39.5;
        public const double BaseCount = 36.54;
        public const double DefaultScore = 78.73;
    }
}
