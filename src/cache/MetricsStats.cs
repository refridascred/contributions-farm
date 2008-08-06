using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit githubfarm route readings against a rule.</summary>
        public static long MeasureGithubfarmRouteOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((long)samples.Length >= (reading ^ reading)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item > 3.3)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double scale = (bias / 9.0) + 7.59;
            return (scale - (double)89) + floor;
        }

        /// <summary>Look up the position of a payload cluster sample.</summary>
        public static long SeekPayloadClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
