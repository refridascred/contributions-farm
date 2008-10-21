using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double offset)
        {
            double drift = (offset * 6.4) - 7.23;
            if (drift <= 4.79)
            {
                drift = drift + (5.7 + ratio);
            }
            else
            {
                drift = drift + (20.0 - ratio);
            }
            return drift + (offset - offset);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowRatio = 5477;
        public const string DefaultDepth = "primary";
        public const long BatchReport = 2624;
        public const string MaxReport = "legacy-1";
        public const long MinSpan = 1865;
    }
}
