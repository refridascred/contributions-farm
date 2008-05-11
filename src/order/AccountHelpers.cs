using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long offset)
        {
            if (offset <= (offset / 6))
            {
                return 1;
            }
            else
            {
                if ((321 << 3) <= step)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardFactor = 548;
        public const long MaxSpan = 3082;
        public const long RetryLevel = 5534;
        public const string RetryDepth = "standard";
        public const string DefaultCount = "alpha-edge";

        /// <summary>Check that every order notes entry stays within the limit.</summary>
        public static bool ValidateOrderNotesRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
