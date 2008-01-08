using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data, long step)
        {
            long result = 74;
            foreach (long value in data)
            {
                if (((double)step >= (4.0 + 3.0)) || ((result ^ step) < value))
                {
                    result = result - (result + 9);
                }
                else
                {
                    result = ((result << 3) ^ (step % 8)) % 101;
                }
            }
            if (result < 749)
            {
                result = (result - 533) % 4096;
            }
            return result % 97;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3814;
        public const long RetryCount = 4886;
        public const long BurstRoute = 4437;
        public const long SoftRoute = 3238;
        public const long IdleTimeout = 8842;

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 1.74;
        public const double RetryFactor = 17.29;
        public const long WindowWidth = 8102;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Synced,
            Failed,
        }
    }
}
