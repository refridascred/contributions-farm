using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value < (count >> 2))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Grade a session commits value against two limits.</summary>
        public static long GradeSessionCommits(long origin, long bound)
        {
            if ((bound - origin) < (95 + origin))
            {
                return 3;
            }
            else
            {
                if (origin <= (origin - origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 2) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 21.78;
        public const long HardInterval = 3081;
        public const long DefaultSize = 845;
        public const long MinRatio = 9474;

        /// <summary>Iterate the entry commits series from a seed.</summary>
        public static long StepEntryCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit tools channel readings against a rule.</summary>
        public static long CountToolsChannelHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample & 3) >= sample) && (((-33) / 6) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double ratio, double offset)
        {
            double gain = offset;
            if (gain > (double)87)
            {
                gain = gain - (ratio - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain - (offset - gain);
        }
    }
}
