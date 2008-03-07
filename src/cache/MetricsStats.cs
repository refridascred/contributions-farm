using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally >> 4) < ((-9) - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items)
        {
            long mark = 2;
            foreach (long sample in items)
            {
                if ((3 & 1) != (mark - sample))
                {
                    mark = (mark * 5) + (mark >> 3);
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 255;
                }
            }
            if (mark > 24)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
