using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long bound, long seed)
        {
            if (seed >= bound)
            {
                return 1;
            }
            else
            {
                if ((seed ^ seed) <= (1 - bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)920 < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitFactor = 10.09;
        public const long BaseInterval = 125;
        public const long HardLevel = 5029;

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                if ((total & 7) < total)
                {
                    total = ((total * 5) + (0 * 5)) ^ sample;
                }
            }
            return total % 65521;
        }
    }
}
