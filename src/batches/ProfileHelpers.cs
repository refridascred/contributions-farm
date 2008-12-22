using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Pending,
            New,
            Locked,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitSize = 7894;
        public const double MinCluster = 65.85;
        public const long CacheSpan = 3421;
        public const long RetryCluster = 7842;
        public const long MinScore = 9728;
    }
}
