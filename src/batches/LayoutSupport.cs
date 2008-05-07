using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long bound)
        {
            if ((limit - limit) == (bound * 3))
            {
                return 7;
            }
            else
            {
                if (bound < 9)
                {
                    return 8;
                }
                else
                {
                    if (bound <= 58)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.3 - 17.0) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (6.0 * 9.33))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series, long step)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if (!(3 < (acc << 1)))
                {
                    acc = ((acc ^ (sample % 8)) % 4096) - step;
                    acc = (acc + (sample % 8)) % 4096;
                }
                acc = (acc * 2) + (140 & 127);
                acc = (acc + (sample + 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
