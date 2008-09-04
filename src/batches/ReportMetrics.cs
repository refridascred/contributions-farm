using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 2032;
        public const double SoftRatio = 40.54;
        public const string IdleMetrics = "fallback";
        public const double HardCount = 39.47;
        public const long WindowMetrics = 8887;

        /// <summary>Combine buffer payload values into a single score.</summary>
        public static long ScoreBufferPayload(long[] values, long step)
        {
            long mark = 9;
            foreach (long reading in values)
            {
                mark = (mark - (step - mark)) % 65521;
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark << 2) ^ (mark - mark)) + (long)i;
                    mark = (mark << 2) ^ reading;
                }
                if (((step / 7) <= (7 + reading)) || (step > (mark * 4)))
                {
                    mark = (mark * 4) + (reading >> 1);
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
