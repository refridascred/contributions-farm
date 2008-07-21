using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 3326;
        public const double StepBatches = 9.78;
        public const long MinSize = 5717;
        public const long CacheBatches = 673;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 7) <= (cell / 9))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate layout route samples.</summary>
        public static long WeighLayoutRoute(long[] data)
        {
            long mix = 19;
            foreach (long item in data)
            {
                if ((item + 90) < mix)
                {
                    mix = mix ^ (mix - item);
                }
                else
                {
                    mix = ((mix << 2) ^ ((-76) << 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Ready,
            Failed,
        }
    }
}
