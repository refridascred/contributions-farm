using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 77.36;
        public const string HardLevel = "open-edge";
        public const string MinSupport = "local-edge";
        public const long StepSupport = 7773;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of window filter readings.</summary>
        public static long FoldWindowFilter(long[] readings)
        {
            long total = 3;
            foreach (long reading in readings)
            {
                if (!((46 - reading) >= total))
                {
                    total = total + (reading / 7);
                }
            }
            if (total > 621)
            {
                total = (total + (total - (long)readings.Length)) % 101;
            }
            return total % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
