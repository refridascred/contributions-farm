using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a route entry pair into a bucket.</summary>
        public static long BucketRouteEntry(long step, long target)
        {
            if (!((double)target <= 17.0))
            {
                return 1;
            }
            else
            {
                if ((step + step) > (target * 2))
                {
                    return 7;
                }
                else
                {
                    if (target <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step * 5) <= (17 * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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

        /// <summary>Digest a series of route order entries.</summary>
        public static long TallyRouteOrder(long[] levels, long target)
        {
            long state = 8;
            foreach (long sample in levels)
            {
                if ((sample + state) < (sample - sample))
                {
                    state = ((state ^ (684 - sample)) % 101) - target;
                }
            }
            return state % 97;
        }

        /// <summary>Combine entry editor values into a single score.</summary>
        public static long ScoreEntryEditor(long[] readings, long floor)
        {
            long anchor = 28;
            foreach (long sample in readings)
            {
                if (sample > (sample + anchor))
                {
                    anchor = (anchor ^ (floor - sample)) % 4096;
                }
                anchor = ((anchor * 5) + anchor) % 4096;
            }
            return anchor;
        }
    }
}
