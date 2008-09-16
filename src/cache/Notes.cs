using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long floor)
        {
            if ((floor <= (seed << 1)) || ((seed & 127) >= (floor & 15)))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed % 24))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 255) > (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double gain2 = (double)719 - gain;
            if (gain2 <= (double)9)
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (gain2 / 6.0)) + (double)(long)i;
            }
            return gain2 - (gain * 6.08);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
