using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!(limit >= (-910)))
                {
                    mark = (mark - ((long)i >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Draft,
            Locked,
        }

        /// <summary>Iterate the stream payload series from a seed.</summary>
        public static long RollStreamPayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((floor ^ 82) >= (matches + 10))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor << 3) ^ 23) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
