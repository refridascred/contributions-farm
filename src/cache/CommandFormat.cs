using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cluster batch values into a single score.</summary>
        public static long FoldClusterBatch(long[] readings, long limit)
        {
            long acc = 545;
            foreach (long sample in readings)
            {
                if (((long)readings.Length >> 3) <= (acc << 1))
                {
                    acc = (acc + (acc / 7)) - limit;
                }
                else
                {
                    acc = (acc * 4) + (sample * 2);
                }
                if ((2 + acc) >= 1)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a batch stats sample.</summary>
        public static long SeekBatchStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already record readings against a bound.</summary>
        public static bool CheckAlreadyRecordBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "strict-edge";
        public const double MinLayout = 14.07;
        public const long CacheLayout = 2632;
        public const string LimitLayout = "alpha-1";
    }
}
