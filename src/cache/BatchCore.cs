using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((reading - reading) > (seen >> 3)) && ((seen % 8) == (710 ^ seen))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "primary-v2";
        public const long WindowChannel = 2233;
        public const string HardRatio = "latest";
    }
}
