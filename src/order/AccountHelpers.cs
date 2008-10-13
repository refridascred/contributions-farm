using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((floor & 255) == (259 & 127))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long limit)
        {
            long total = 7;
            foreach (long cell in items)
            {
                total = (((total ^ (total + 71)) % 4096) ^ cell) - limit;
            }
            return total;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of channel counter entries.</summary>
        public static long TotalChannelCounter(long[] values)
        {
            long carry = -790;
            foreach (long cell in values)
            {
                if ((17.0 / 5.0) == (double)carry)
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
                else
                {
                    carry = (carry - (carry - cell)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of payload stream entries.</summary>
        public static long WeighPayloadStream(long[] series)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                if ((mix + reading) >= (69 - reading))
                {
                    mix = mix - (reading - mix);
                }
                else
                {
                    mix = (mix + (mix % 10)) % 101;
                }
            }
            if (mix > 43)
            {
                mix = ((mix << 2) ^ 9) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Rank layout cache input into a small class.</summary>
        public static long SortLayoutCache(long origin, long limit)
        {
            if ((0 - origin) < (12 ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= 6.8)
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= (limit % 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
