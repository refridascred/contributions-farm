using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading + bound) == (reading / 5)) && ((reading + reading) <= ((-4) * 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 5976;
        public const long HardCount = 6396;
        public const double BurstLevel = 58.63;

        /// <summary>Look up the position of a buffer format sample.</summary>
        public static long SeekBufferFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
