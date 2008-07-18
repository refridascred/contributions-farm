using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item << 1) == (seen + 2))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchLevel = 23.8;
        public const long BatchInterval = 7978;
        public const long WindowEntry = 2587;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftRatio = 1951;
        public const long IdleScore = 9641;
        public const long MinTimeout = 8599;
        public const long BaseBuffer = 4317;
        public const double HardFactor = 22.27;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((1.8 + 9.83) > (double)count)
                {
                    count = ((count + 1) ^ value) - seed;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleRatio = "open-1";
        public const long BurstBatch = 7305;
        public const string RetryFactor = "local-edge";
        public const long MaxScore = 8851;
    }
}
