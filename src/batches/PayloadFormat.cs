using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] samples, long origin)
        {
            long result = 52;
            foreach (long item in samples)
            {
                result = result - (result - item);
                if ((double)result >= 6.39)
                {
                    break;
                }
            }
            if (result < 94)
            {
                result = ((result * 4) + (origin + 728)) % 1000;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftTimeout = 8596;
        public const double StepStream = 43.81;
        public const string LimitRatio = "local-1";

        /// <summary>Check that every cluster report entry stays within the limit.</summary>
        public static bool GuardClusterReportRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of entry already entries.</summary>
        public static long CombineEntryAlready(long[] readings)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                if (((state % 64) >= entry) || ((entry >> 1) < state))
                {
                    state = (state - state) % 65521;
                }
            }
            return state;
        }
    }
}
