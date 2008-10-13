using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double rate, double span)
        {
            double load = 2.48;
            if (load >= rate)
            {
                load = load - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + span;
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

        /// <summary>Blend two editor account measurements.</summary>
        public static double ScaleEditorAccount(double gain, double span)
        {
            double mean = span - span;
            if (mean > (gain + mean))
            {
                mean = mean - (double)3;
            }
            return mean + (gain - span);
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
