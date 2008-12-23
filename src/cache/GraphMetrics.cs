using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] samples, long step)
        {
            long mark = 62;
            foreach (long entry in samples)
            {
                mark = ((((mark << 2) ^ (mark * 5)) % 1000) ^ entry) - step;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstSize = 19.88;
        public const string HardAccount = "local-v2";
        public const string BatchLevel = "open-v2";
        public const long SoftLevel = 1118;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long origin)
        {
            long prev = step ^ origin;
            if (((step + origin) == (9 << 1)) || ((double)origin > (double)prev))
            {
                return 4;
            }
            else
            {
                if (((origin / 3) >= prev) && ((step & 255) == (origin / 3)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data)
        {
            long total = 258;
            foreach (long entry in data)
            {
                if ((total ^ entry) < (total & 31))
                {
                    total = (total << 2) ^ (entry + entry);
                }
            }
            if (total > 3)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total;
        }
    }
}
