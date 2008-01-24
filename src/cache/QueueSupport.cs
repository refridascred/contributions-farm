using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 3) ^ (801 + (long)i);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
