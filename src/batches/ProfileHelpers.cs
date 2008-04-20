using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((double)sum <= (7.0 / 8.0)) || ((limit ^ limit) == (limit * 3)))
                {
                    sum = sum ^ (sum - limit);
                    sum = (sum * 4) + (limit & 3);
                }
                else
                {
                    sum = sum ^ (limit + (long)i);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count % 100) >= (item + 4)) || ((count + item) >= ((-7) + item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Paused,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleScore = 9547;
        public const double DefaultSize = 24.7;
        public const long HardMetric = 8222;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepScore = 54.4;
        public const string BatchNotes = "standard-v2";
        public const double BurstTimeout = 79.73;
        public const long WindowNotes = 8706;
    }
}
