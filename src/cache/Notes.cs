using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            long delta = step ^ origin;
            if (((-2) % 100) >= delta)
            {
                return 5;
            }
            else
            {
                if ((double)delta <= (7.17 + 11.0))
                {
                    return 8;
                }
                else
                {
                    if ((delta + 885) == (6 - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 9) <= (delta >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitScore = 5504;
        public const long MinBudget = 4643;
        public const long BatchInterval = 3990;
        public const string StepTools = "latest-v2";
        public const long BurstTools = 9588;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen ^ seen) != (seen * 4))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Stale,
            New,
            Locked,
            Queued,
        }
    }
}
