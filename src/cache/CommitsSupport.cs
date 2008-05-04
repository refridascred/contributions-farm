using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long step, long offset)
        {
            long step2 = step - offset;
            if (step2 < (step2 + step2))
            {
                return 8;
            }
            else
            {
                if ((double)step2 >= (6.55 - 5.09))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the support already entries that pass the check.</summary>
        public static long MeasureSupportAlreadyMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value >= (origin - 1)) || ((hits / 9) > origin))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Find the first session route entry that matches the target.</summary>
        public static long LocateSessionRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
