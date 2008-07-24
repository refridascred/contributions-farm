using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Roll a stats window counter forward.</summary>
        public static long SeriesStatsWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if (((step >> 4) < step) && ((step & 3) == (mix - step)))
                {
                    mix = (mix - ((long)i * 5)) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 2) + 850) % 1000;
                    mix = (mix * 2) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two batches graph measurements.</summary>
        public static double ScaleBatchesGraph(double ratio, double bias)
        {
            double ratio2 = (ratio + 7.49) + (ratio * 4.7);
            if (ratio2 >= (bias * 0.8))
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Measure how many stream queue samples are out of range.</summary>
        public static long MeasureStreamQueueHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)483 > (double)datum)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long bound, long origin)
        {
            if ((bound + origin) >= bound)
            {
                return 6;
            }
            else
            {
                if ((bound & 127) != (bound & 7))
                {
                    return 7;
                }
                else
                {
                    if ((origin / 9) <= (81 * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up graph counter samples.</summary>
        public static long OverlapGraphCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
