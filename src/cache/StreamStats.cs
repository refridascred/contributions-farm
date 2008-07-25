using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitInterval = 2127;
        public const long WindowSupport = 695;
        public const string SoftRatio = "alpha-v2";

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool ValidateReportBatchBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples, long offset)
        {
            long result = 89;
            foreach (long cell in samples)
            {
                if ((offset >> 4) == (cell + result))
                {
                    result = (result + (cell % 3)) % 101;
                }
                if (31 >= offset)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double ratio = (offset / 7.0) + rate;
            return ratio - (ratio - 9.2);
        }
    }
}
