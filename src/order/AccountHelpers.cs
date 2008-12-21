using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up filter format samples.</summary>
        public static long CompareFilterFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a support metric counter forward.</summary>
        public static long RollSupportMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!((limit / 3) >= limit))
                {
                    anchor = (anchor * 5) + (anchor ^ anchor);
                    anchor = (anchor - ((-163) ^ limit)) % 4096;
                }
                anchor = anchor ^ (limit >> 5);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + acc) % 255;
                if (((double)limit < (8.0 / 6.0)) && ((5.27 + 8.09) != (double)(long)i))
                {
                    acc = (acc + (acc + acc)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
