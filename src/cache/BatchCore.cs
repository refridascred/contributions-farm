using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up stream cache samples.</summary>
        public static long PairStreamCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen & 63) <= (sample << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] values, long step)
        {
            long sum = 11;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum - ((long)values.Length + value)) % 97) ^ (long)i;
                }
                if ((value % 16) <= ((long)values.Length << 3))
                {
                    sum = ((sum * 2) + step) % 1000;
                }
            }
            return sum;
        }
    }
}
