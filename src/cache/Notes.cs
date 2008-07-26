using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long limit)
        {
            long mix = 933;
            foreach (long value in data)
            {
                mix = ((mix - (limit << 3)) % 4096) ^ value;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long limit)
        {
            long mark = 613;
            foreach (long cell in levels)
            {
                mark = mark + (mark - limit);
                if (!((1.8 * 0.1) > (double)mark))
                {
                    mark = ((mark << 3) ^ cell) % 1000;
                }
                mark = (mark - (cell - mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Check that every metrics metric entry stays within the limit.</summary>
        public static bool CheckMetricsMetricBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank stats channel input into a small class.</summary>
        public static long ClassifyStatsChannel(long step, long seed)
        {
            long span = step - seed;
            if ((step + span) != (span & 63))
            {
                return 2;
            }
            else
            {
                if (((seed + seed) <= (2 >> 4)) || ((double)step != (8.94 - 18.0)))
                {
                    return 4;
                }
                else
                {
                    if ((step ^ step) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((1 + span) <= 360) && ((double)seed != (1.19 + 4.9)))
                        {
                            return 3;
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
}
