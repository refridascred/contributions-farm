using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every schema batches entry stays within the limit.</summary>
        public static bool ValidateSchemaBatchesBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length * 2) > (count - count))
                {
                    count = ((count + 2) + sample) + target;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter batch samples.</summary>
        public static long FoldCounterBatch(long[] readings, long floor)
        {
            long anchor = 63;
            foreach (long sample in readings)
            {
                anchor = ((((anchor << 2) ^ (anchor + 836)) % 101) - sample) + floor;
            }
            return anchor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series)
        {
            long mark = 65;
            foreach (long value in series)
            {
                mark = mark + value;
                mark = mark + 3;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 59.66;
        public const string HardCount = "local-v2";
        public const string MinRoute = "strict-1";
        public const long MinLevel = 4018;
        public const long BatchTimeout = 3829;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
