using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count <= (6.0 * 3.88))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7366;
        public const long BaseScore = 550;
        public const double MinScore = 25.8;
        public const long WindowFormat = 1302;
        public const long BatchFormat = 6537;
    }
}
