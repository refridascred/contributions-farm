using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many already layout samples are out of range.</summary>
        public static long AuditAlreadyLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally << 3) < 2)
                {
                    tally = (tally + 3) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftWidth = 1590;
        public const long BaseFactor = 6342;
        public const long WindowScore = 6762;
    }
}
