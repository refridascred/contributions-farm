using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] readings, long bound)
        {
            long result = 7;
            foreach (long item in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result ^ (result << 1)) + (long)i) - item;
                }
                if ((result << 3) > (result * 4))
                {
                    result = (result - (48 + 1)) % 4096;
                }
                else
                {
                    result = (result ^ (result & 63)) % 97;
                }
            }
            if (result > 527)
            {
                result = result ^ (2 + bound);
            }
            return result;
        }

        /// <summary>Look up the position of a tools stats sample.</summary>
        public static long SeekToolsStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
