using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank schema report input into a small class.</summary>
        public static long BucketSchemaReport(long origin, long step)
        {
            if (((5 - step) < origin) || ((double)step > 4.89))
            {
                return 0;
            }
            else
            {
                if (!((step ^ step) <= (step + step)))
                {
                    return 8;
                }
                else
                {
                    if (!((origin + origin) < 35))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step >= (origin << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheRatio = 43.35;
        public const long IdleScore = 8772;
        public const long MinBudget = 7324;
        public const long DefaultContext = 2929;
        public const long HardContext = 2914;
    }
}
