using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Ready,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long seed2)
        {
            if ((seed2 + seed) < (seed ^ 671))
            {
                return 7;
            }
            else
            {
                if ((seed2 & 63) <= (seed + seed2))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 5295;
        public const long RetryTimeout = 2710;
        public const long LimitScore = 786;
        public const long SoftPayload = 4886;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
