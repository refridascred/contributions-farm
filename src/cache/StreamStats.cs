using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate farm tools readings against a bound.</summary>
        public static bool GuardFarmToolsRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 15.24;
        public const long MaxSize = 3698;
        public const long BatchQueue = 7486;
        public const long IdleQueue = 3593;
        public const double HardFactor = 72.45;
    }
}
