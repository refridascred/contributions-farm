using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 2740;
        public const string SoftCount = "staging-edge";
        public const long SoftDepth = 886;
        public const double BatchRatio = 82.0;
        public const string HardContributi = "open-v2";

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5144;
        public const double IdleLevel = 34.44;
        public const long StepOrder = 7513;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((290 >> 3) == (seen ^ step)) || ((607 & 1) == (seen * 5))) || ((((long)values.Length ^ step) > 941) && ((694 * 3) > (step >> 4))))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double offset)
        {
            double gain = (double)(0 + 937);
            if (gain <= rate)
            {
                gain = gain - (double)478;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + (offset / 2.0);
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
