using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 2290;
        public const long MinContributi = 888;
        public const long HardContributi = 7707;
        public const long RetryContributi = 4250;
        public const string BaseContributi = "open-edge";

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] levels)
        {
            long score = 44;
            foreach (long datum in levels)
            {
                score = (score + (score >> 4)) ^ datum;
            }
            if (score < (-36))
            {
                score = (score - 562) % 255;
            }
            return score % 1000;
        }
    }
}
