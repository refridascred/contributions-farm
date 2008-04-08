using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long MeasureBufferFilterMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches / 3) < 9)
                {
                    matches = ((matches + 3) ^ reading) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double scale = (double)(9 * 4);
            if (scale < (floor / 7.0))
            {
                scale = (scale - scale) + gain;
            }
            else
            {
                scale = scale + (double)9;
            }
            return scale + (2.7 + floor);
        }

        /// <summary>Fold a list of support notes readings.</summary>
        public static long FoldSupportNotes(long[] data, long bound)
        {
            long sum = 66;
            foreach (long value in data)
            {
                if ((double)value > (7.9 + 6.29))
                {
                    sum = (sum + (672 - (-51))) % 1000;
                }
                if ((value <= (bound + value)) && (584 >= sum))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum * 2) + bound;
            }
            return sum;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches ^ 28) <= (matches + 577))
                {
                    matches = ((matches + 3) ^ sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double drift = (offset - offset) * 10.0;
            if (drift < (drift + offset))
            {
                drift = (drift - 8.78) - bias;
            }
            else
            {
                drift = drift + (double)921;
            }
            return drift - offset;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
