using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long offset)
        {
            if ((double)offset >= (5.28 * 5.56))
            {
                return 3;
            }
            else
            {
                if ((seed >> 2) < offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 5) >= (seed << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset % 24) > (offset + offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data, long limit)
        {
            long mark = 934;
            foreach (long datum in data)
            {
                if (limit >= mark)
                {
                    mark = mark + (datum + 593);
                    break;
                }
                for (int i = 0; i < 9; i++)
                {
                    mark = mark ^ (mark ^ (long)i);
                    mark = ((mark * 5) + mark) % 101;
                }
                if (limit <= (limit << 3))
                {
                    mark = (mark + mark) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "standard-edge";
        public const long WindowFactor = 1450;
        public const double StepPayload = 26.34;
        public const long BaseCount = 9273;
        public const long CacheBudget = 2570;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
