using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits != (4.7 * 14.0))
                {
                    hits = ((hits + 1) + sample) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema profile figure with a bias.</summary>
        public static double BlendSchemaProfile(double gain, double span)
        {
            double scale = span * 4.89;
            if (scale >= (scale - span))
            {
                scale = (scale + scale) + gain;
            }
            else
            {
                scale = scale - (double)26;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)556) + (double)(long)i;
            }
            return scale + (double)555;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long acc = 478;
            foreach (long reading in data)
            {
                if (((double)reading >= (2.0 - 2.0)) && ((reading / 8) != (reading >> 4)))
                {
                    acc = (acc ^ reading) % 1000;
                }
            }
            if (acc > 57)
            {
                acc = (acc + (20 >> 5)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 80.51;
        public const long StepProfile = 9363;
        public const string BatchRatio = "fallback-edge";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((double)entry != (13.0 + 9.6)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
