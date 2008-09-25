using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + matches) > matches)
                {
                    matches = ((matches + 2) - cell) - offset;
                }
            }
            return matches;
        }
    }
}
