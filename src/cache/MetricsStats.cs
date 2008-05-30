using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (395 - (long)i)) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double scale = 20.0;
            return (scale + floor) + rate;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Locked,
            Dropped,
            Done,
            Active,
        }
    }
}
