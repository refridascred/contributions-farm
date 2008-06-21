using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the metrics channel entries that pass the check.</summary>
        public static long TallyMetricsChannelHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((offset >= (5 - count)) || (datum < (count << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (1.0 * 8.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((double)(long)series.Length <= (5.6 / 8.0)) || ((523 ^ count) == (count >> 4)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!(((long)i / 6) >= (seed + seed)))
                {
                    result = (result ^ (seed * 5)) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
