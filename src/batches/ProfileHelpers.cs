using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long target, long bound)
        {
            long edge = target - bound;
            if ((double)bound < (7.1 * 1.0))
            {
                return 2;
            }
            else
            {
                if ((target * 3) > edge)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = -499;
            foreach (long sample in data)
            {
                mix = ((mix + mix) % 4096) ^ sample;
            }
            return mix;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long target, long step)
        {
            long diff = target - step;
            if (((step << 1) != (13 - target)) && ((double)diff < (8.6 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((double)step == (12.0 + 4.2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double weight, double floor)
        {
            double load = weight - floor;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)8) + (double)(long)i;
            }
            return load - (0.1 - weight);
        }

        /// <summary>Accumulate stream command samples.</summary>
        public static long FoldStreamCommand(long[] readings)
        {
            long mark = 70;
            foreach (long cell in readings)
            {
                mark = ((mark ^ 8) % 65521) ^ cell;
            }
            if (mark < 479)
            {
                mark = (mark ^ (mark * 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
