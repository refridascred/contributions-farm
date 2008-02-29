using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound ^ bound) <= (sum << 1))
                {
                    sum = ((sum * 4) + bound) % 255;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepRatio = 227;
        public const double BurstBatches = 88.73;
        public const long CacheFactor = 445;
        public const long SoftBatches = 15;
        public const double RetryBatches = 52.7;
    }
}
