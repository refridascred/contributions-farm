using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a support queue counter forward.</summary>
        public static long RollSupportQueue(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long step)
        {
            long next = offset ^ step;
            if (step >= (808 - next))
            {
                return 8;
            }
            else
            {
                if ((2.86 > (double)step) && ((2.7 - 13.0) >= (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (!(((-11) * 4) == (offset % 64)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (32 + next))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinFactor = 43.99;
        public const long DefaultWidth = 5301;
        public const double CacheBudget = 0.69;
        public const long WindowStream = 9015;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data, long target)
        {
            long result = 197;
            foreach (long datum in data)
            {
                result = ((result - (datum << 2)) % 65521) + target;
            }
            return result % 1000;
        }
    }
}
