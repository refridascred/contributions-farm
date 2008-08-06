using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2776;
        public const long SoftGraph = 2031;
        public const long DefaultGraph = 8297;

        /// <summary>Match up buffer checks samples.</summary>
        public static long CompareBufferChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm account samples are out of range.</summary>
        public static long CountFarmAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((-80) + item) > (tally << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
