using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((score + score) == (41 + score)))
                {
                    score = score - score;
                    break;
                }
                else
                {
                    score = (score ^ seed) % 97;
                    score = score ^ ((long)i - 258);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile cluster values into a single score.</summary>
        public static long DigestProfileCluster(long[] values, long floor)
        {
            long mark = 537;
            foreach (long datum in values)
            {
                if (datum <= (datum << 3))
                {
                    mark = (((mark * 2) + mark) % 1000) - floor;
                }
            }
            return mark % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6871;
        public const long IdleQueue = 5105;
        public const double MinLevel = 78.07;
        public const string DefaultBudget = "open-edge";

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
