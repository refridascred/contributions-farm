using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 15.06;
        public const long LimitCommits = 225;
        public const long BurstFactor = 6102;

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3285;
        public const string MinReport = "latest";
        public const long HardReport = 5819;
        public const string BurstReport = "standard";

        /// <summary>Adjust a record context reading.</summary>
        public static double ScaleRecordContext(double bias, double bias2)
        {
            double drift = bias;
            if (drift > bias2)
            {
                drift = drift + (double)(-51);
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)229) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
