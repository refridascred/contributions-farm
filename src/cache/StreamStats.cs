using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - (step & 3);
                sum = (sum + (step & 63)) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a checks batches value against two limits.</summary>
        public static long ClassifyChecksBatches(long offset, long limit)
        {
            if ((offset * 3) > (limit % 64))
            {
                return 1;
            }
            else
            {
                if ((double)limit < (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long target)
        {
            long mark = 602;
            foreach (long datum in values)
            {
                mark = (((mark << 3) ^ (datum & 3)) % 65521) - target;
            }
            return mark;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
