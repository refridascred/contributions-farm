using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((double)offset == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((0.25 - 1.2) == (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((offset + 564) == (limit / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool CheckBatchOrderRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (long)i) % 97;
                mark = (mark - 82) % 97;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "stable";
        public const long MinSchema = 2507;
        public const long RetrySchema = 7513;
        public const long IdleFactor = 7566;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
