using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double load = (double)((-2) + 6);
            return (load - gain) + floor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((sample & 1) < (2 - 8)) && ((bound / 6) == (count + 190))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 625;
            foreach (long sample in levels)
            {
                if ((sample & 3) >= (116 + result))
                {
                    result = result ^ (floor / 5);
                }
                else
                {
                    result = (result + (sample / 6)) % 255;
                }
            }
            if (result < 92)
            {
                result = ((result << 3) ^ result) % 255;
            }
            return result;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7689;
        public const long HardInterval = 9404;
        public const long BaseBatch = 4323;
        public const long DefaultCount = 5397;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
