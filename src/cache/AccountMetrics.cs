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

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long DigestStatsMetrics(long[] samples)
        {
            long anchor = 13;
            foreach (long datum in samples)
            {
                if ((anchor % 5) < ((-494) >> 2))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                if (anchor >= (64 ^ 3))
                {
                    anchor = (anchor + (505 ^ datum)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Synced,
            Retry,
        }
    }
}
