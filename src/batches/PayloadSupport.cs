using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 2044;
        public const long MinWidth = 2154;
        public const double MaxStats = 25.35;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a channel metrics counter forward.</summary>
        public static long SeriesChannelMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!((limit / 8) <= (-9)))
                {
                    sum = (sum - (sum + 7)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
