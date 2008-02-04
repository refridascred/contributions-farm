using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a counter metric reading by value.</summary>
        public static long LocateCounterMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data)
        {
            long total = 1;
            foreach (long entry in data)
            {
                total = (total + entry) % 4096;
                if ((entry + total) == (total & 1))
                {
                    total = (total - total) % 97;
                }
                if ((double)total >= (0.9 - 9.78))
                {
                    total = total - (entry << 3);
                }
                if (!((entry % 3) < (total + entry)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every queue buffer entry stays within the limit.</summary>
        public static bool CheckQueueBufferLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a farm batch counter forward.</summary>
        public static long DeriveFarmBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((6.88 - 1.0) > (double)score)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
