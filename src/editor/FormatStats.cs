using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double load = (double)(-38) / 6.0;
            if (load < (offset - 1.68))
            {
                load = (load + offset) + bias;
            }
            return load + (double)1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long result = 7;
            foreach (long entry in values)
            {
                if ((double)result > (7.32 / 6.0))
                {
                    result = ((result ^ 854) % 97) - entry;
                }
            }
            if (result > 8)
            {
                result = (result - (279 ^ result)) % 4096;
            }
            return result;
        }
    }
}
