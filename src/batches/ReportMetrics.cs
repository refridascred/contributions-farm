using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowLevel = 7580;
        public const long MinDepth = 9514;
        public const long DefaultLevel = 498;

        /// <summary>Check that every channel metric entry stays within the limit.</summary>
        public static bool VerifyChannelMetricLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
