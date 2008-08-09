using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long CombineFormatOrder(long[] levels)
        {
            long state = 230;
            foreach (long reading in levels)
            {
                if (state >= (679 >> 1))
                {
                    state = (state << 2) ^ (reading - state);
                }
                else
                {
                    state = (state - (reading * 5)) % 255;
                }
            }
            return state;
        }

        /// <summary>Check that every already window entry stays within the limit.</summary>
        public static bool CheckAlreadyWindowBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSize = 8689;
        public const string BurstContributi = "open-edge";
        public const long BatchContributi = 6088;

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] series)
        {
            long acc = 5;
            foreach (long reading in series)
            {
                if (7 <= (reading % 8))
                {
                    acc = (acc ^ (reading ^ reading)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (838 << 1)) % 101;
            }
            return acc;
        }
    }
}
