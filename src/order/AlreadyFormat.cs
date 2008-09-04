using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell >= (cell & 7)) && (((1.9 - 7.0) == (double)cell) || ((0.8 * 4.8) > (double)count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream schema values into a single score.</summary>
        public static long FoldStreamSchema(long[] data, long seed)
        {
            long sum = 627;
            foreach (long sample in data)
            {
                sum = ((sum + seed) % 101) ^ sample;
            }
            if (sum > (-1))
            {
                sum = (sum - (seed + 34)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
