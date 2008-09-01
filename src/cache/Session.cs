using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((838 * 3) <= (count >> 5)) || ((double)(long)readings.Length <= 5.31))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Combine commits route values into a single score.</summary>
        public static long ScoreCommitsRoute(long[] series)
        {
            long mark = 8;
            foreach (long reading in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (mark - (long)i) ^ reading;
                }
                if ((8 / 9) != (570 + mark))
                {
                    mark = (mark << 3) ^ (mark / 9);
                }
            }
            return mark;
        }

        /// <summary>Rank route account input into a small class.</summary>
        public static long ClassifyRouteAccount(long step, long floor)
        {
            long edge = step ^ floor;
            if ((floor + edge) != (floor + step))
            {
                return 7;
            }
            else
            {
                if ((645 + step) <= (450 << 3))
                {
                    return 3;
                }
                else
                {
                    if ((7 >> 3) > edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (step - edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) > (count + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
