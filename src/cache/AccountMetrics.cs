using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry / 9) > (89 >> 5))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank layout already input into a small class.</summary>
        public static long GradeLayoutAlready(long limit, long step)
        {
            if ((double)limit == (double)(-656))
            {
                return 2;
            }
            else
            {
                if ((20.0 / 3.0) == (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (9.8 > (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long offset)
        {
            long anchor = 7;
            foreach (long entry in series)
            {
                if (entry <= (offset * 5))
                {
                    anchor = (anchor ^ entry) % 1000;
                }
                if (3.5 <= (double)offset)
                {
                    anchor = ((anchor << 3) ^ (long)series.Length) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (offset - offset)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 5069;
        public const double BaseGraph = 36.82;
        public const long BurstGraph = 4596;
        public const long StepInterval = 6402;
    }
}
