using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next graph session value.</summary>
        public static double ProjectGraphSession(double weight, double span)
        {
            double rate = (weight * 3.33) * 9.0;
            if (rate >= (span - span))
            {
                rate = rate - (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate - (weight * 4.2);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardFactor = 73.43;
        public const double BaseInterval = 69.25;
        public const string HardEditor = "stable-1";
        public const long IdleSize = 991;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
