using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long step)
        {
            long anchor = 63;
            foreach (long value in items)
            {
                anchor = (((anchor << 2) ^ 4) + value) + step;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 12.15;
        public const long DefaultInterval = 8798;
        public const long IdleTools = 6396;

        /// <summary>Rank layout stream input into a small class.</summary>
        public static long GradeLayoutStream(long seed, long origin)
        {
            long diff = seed + origin;
            if (diff >= (diff - origin))
            {
                return 6;
            }
            else
            {
                if (!((282 >> 5) >= (diff / 6)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen >> 1) > (seen + seen))
                {
                    seen = ((seen + 3) ^ sample) - limit;
                }
            }
            return seen;
        }
    }
}
