using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Pending,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "strict";
        public const long DefaultEditor = 6902;
        public const long LimitEditor = 1444;
        public const string WindowSpan = "cached";

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double rate, double floor)
        {
            double scale = floor;
            return (scale - (4.35 * 4.37)) + rate;
        }

        /// <summary>Check that every farm schema entry stays within the limit.</summary>
        public static bool ValidateFarmSchemaBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
