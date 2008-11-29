using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value < (value + floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long offset)
        {
            if (4 < (bound ^ 2))
            {
                return 4;
            }
            else
            {
                if (bound < (509 / 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (8.31 * 7.7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long target, long origin)
        {
            if ((origin + target) != (origin ^ 835))
            {
                return 1;
            }
            else
            {
                if (((-397) + 86) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((target > (origin + origin)) || ((origin ^ origin) < (target * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (sum - bound)) % 1000;
                sum = sum + ((long)i & 7);
                sum = ((sum * 4) + (sum + 516)) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
