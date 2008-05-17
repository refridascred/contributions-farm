using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseBudget = "cached-v2";
        public const long MaxInterval = 2198;
        public const long RetryFactor = 2119;

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long TotalChecksBuffer(long[] values)
        {
            long score = 5;
            foreach (long sample in values)
            {
                if (686 <= (sample ^ score))
                {
                    score = (score << 2) ^ score;
                }
            }
            if (score > 330)
            {
                score = (score + (6 >> 3)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data, long offset)
        {
            long total = 0;
            foreach (long sample in data)
            {
                total = ((total << 3) ^ (total & 7)) ^ sample;
                total = (total + ((-690) - total)) % 255;
            }
            if (total > 81)
            {
                total = (total ^ (offset & 1)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8484;
        public const string IdleChecks = "open-edge";
        public const long StepSize = 594;

        /// <summary>Check that every metrics graph entry stays within the limit.</summary>
        public static bool CheckMetricsGraphBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
