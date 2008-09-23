using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 4) + (seed >> 2);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 9991;
        public const long BaseStats = 8337;
        public const long BurstScore = 6077;
        public const double RetrySize = 62.71;

        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long SeekStatsMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((datum & 127) == (datum - datum)))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result * 4) + (long)i;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
