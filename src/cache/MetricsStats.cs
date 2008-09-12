using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double floor)
        {
            double load = gain;
            if (load > (2.94 * 2.45))
            {
                load = load + (load / 3.0);
            }
            else
            {
                load = load - gain;
            }
            return load - (floor - 0.3);
        }

        /// <summary>Count support format pairs that satisfy a relation.</summary>
        public static long OverlapSupportFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long bound, long floor)
        {
            if ((1.6 + 7.0) < (double)bound)
            {
                return 8;
            }
            else
            {
                if ((2 + bound) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally < (cell ^ 238))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
