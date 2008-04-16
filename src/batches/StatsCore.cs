using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long bound, long bound2)
        {
            if (((bound >> 1) > (8 ^ 638)) || ((bound % 3) != (bound + 735)))
            {
                return 7;
            }
            else
            {
                if (((bound / 9) > (bound + bound)) || (4.2 <= (double)bound))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) <= (bound + bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Find the first command cache entry that matches the target.</summary>
        public static long SeekCommandCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ step) % 97;
                if ((anchor + step) < ((long)i % 12))
                {
                    anchor = anchor - (anchor >> 3);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the commits route entries that pass the check.</summary>
        public static long AuditCommitsRouteGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen % 16) <= (seen - floor)))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
