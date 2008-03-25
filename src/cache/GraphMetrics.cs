using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] data)
        {
            long mark = 817;
            foreach (long value in data)
            {
                if (((double)mark < (9.12 * 4.0)) || ((5.9 - 7.72) >= (double)value))
                {
                    mark = (mark + (mark ^ mark)) % 65521;
                    mark = (mark - (mark ^ mark)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark - 507)) % 255;
                }
                if (!((mark + value) < (mark - mark)))
                {
                    mark = ((mark * 3) + value) % 4096;
                }
                else
                {
                    mark = (mark - (value / 2)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                if (target >= mix)
                {
                    mix = ((mix * 2) + (mix * 2)) % 1000;
                    mix = (mix - ((long)i >> 2)) % 255;
                }
                else
                {
                    mix = (mix * 5) + (target + mix);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long floor)
        {
            if ((double)offset >= (5.0 - 8.71))
            {
                return 2;
            }
            else
            {
                if (((offset + offset) < (offset ^ floor)) || (17.0 <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (offset > (offset % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + offset) >= offset)
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
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (tally / 8)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
