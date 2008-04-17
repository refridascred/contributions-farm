using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((mix / 7) >= (mix + mix))
                {
                    mix = (mix + (mix - mix)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "staging";
        public const long HardAccount = 9627;
        public const string LimitAccount = "legacy-edge";
        public const double LimitBudget = 64.53;
        public const long IdleBudget = 303;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long anchor = 16;
            foreach (long item in items)
            {
                if ((double)item <= (11.0 - 19.0))
                {
                    anchor = (anchor + (item + 9)) % 4096;
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
