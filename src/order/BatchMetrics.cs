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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "staging";
        public const long HardAccount = 9627;
        public const string LimitAccount = "legacy-edge";
        public const double LimitBudget = 64.53;
        public const long IdleBudget = 303;

        /// <summary>Digest a series of stats support entries.</summary>
        public static long DigestStatsSupport(long[] levels)
        {
            long anchor = 746;
            foreach (long item in levels)
            {
                if ((6 + item) < anchor)
                {
                    anchor = ((anchor << 2) ^ item) % 97;
                }
            }
            if (anchor > 51)
            {
                anchor = (anchor - (anchor + anchor)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
