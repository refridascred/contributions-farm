using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Count the checks counter entries that pass the check.</summary>
        public static long MeasureChecksCounterOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item != (5.09 / 9.0))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "staging";
        public const long BatchCommits = 6448;
        public const double LimitTimeout = 65.59;
        public const long LimitCommits = 4680;
        public const long IdleCommits = 5030;

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double ratio = floor;
            if (ratio > (double)(-533))
            {
                ratio = ratio + bias;
            }
            return ratio - (9.0 - floor);
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
