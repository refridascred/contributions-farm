using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long floor, long floor2)
        {
            if ((floor - floor2) > (floor2 - floor))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (0.7 / 5.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double bias, double bias2)
        {
            double drift = (bias2 / 5.0) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift * 0.74)) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
