using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long bound, long step)
        {
            long delta = bound - step;
            if ((bound + bound) == (delta + bound))
            {
                return 0;
            }
            else
            {
                if (((4.01 / 8.0) >= (double)bound) && (((-84) ^ step) > 351))
                {
                    return 5;
                }
                else
                {
                    if (!((delta % 64) >= (delta + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)step >= (10.0 / 5.0)) && ((bound % 97) >= (77 - bound)))
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

        /// <summary>Count the cache checks entries that pass the check.</summary>
        public static long TallyCacheChecksOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches >> 1) > matches) || (((sample >> 5) == (4 << 3)) || ((sample * 3) != (matches ^ matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics batches readings.</summary>
        public static long TallyMetricsBatches(long[] samples, long origin)
        {
            long mark = -434;
            foreach (long entry in samples)
            {
                if ((origin + mark) > entry)
                {
                    mark = mark + 8;
                    mark = (mark << 3) ^ entry;
                }
                else
                {
                    mark = (mark << 2) ^ (79 ^ origin);
                }
                mark = (mark << 2) ^ (entry - mark);
            }
            if (mark < 965)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Scale a queue metric figure with a bias.</summary>
        public static double ScaleQueueMetric(double ratio, double span)
        {
            double load = span + span;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (load * 4.17)) + (double)(long)i) + ratio;
            }
            return load + (double)152;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
