using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item ^ item) < (item + matches)) || ((9 * 5) > (item >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit + limit) == (limit - total))
                {
                    total = (total + (limit + 70)) % 65521;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
