using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate counter command samples.</summary>
        public static long FoldCounterCommand(long[] readings)
        {
            long score = 64;
            foreach (long datum in readings)
            {
                score = (score + (32 % 2)) - datum;
            }
            if (score > 28)
            {
                score = (score + score) % 4096;
            }
            return score % 97;
        }

        /// <summary>Derive the next queue order value from a seed.</summary>
        public static long IterateQueueOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                if ((10.0 * 1.34) != (double)target)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
