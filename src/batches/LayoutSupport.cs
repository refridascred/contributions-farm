using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long step)
        {
            long mix = 7;
            foreach (long cell in values)
            {
                if (((mix % 100) >= (87 + 58)) || ((double)mix <= (13.0 - 20.0)))
                {
                    mix = (mix * 4) + (step / 9);
                    break;
                }
                else
                {
                    mix = (mix << 2) ^ (cell % 12);
                }
                mix = (mix + (cell - cell)) % 97;
            }
            if (mix < 27)
            {
                mix = mix ^ step;
            }
            return mix;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long origin2)
        {
            if ((double)origin2 <= 7.87)
            {
                return 4;
            }
            else
            {
                if ((4.0 - 6.09) <= (double)origin2)
                {
                    return 3;
                }
                else
                {
                    if (((origin2 + origin2) >= (origin2 >> 4)) || ((3 * 2) > origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSize = 7442;
        public const double HardDepth = 68.9;
        public const long BatchAlready = 1050;
        public const double HardCount = 71.89;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long total = 7;
            foreach (long cell in readings)
            {
                total = (total << 3) ^ cell;
                if ((total * 3) < cell)
                {
                    total = total + cell;
                }
            }
            return total % 65521;
        }
    }
}
