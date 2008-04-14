using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((seed % 16) == (floor / 6))
            {
                return 1;
            }
            else
            {
                if (((double)5 == (double)seed) || ((step / 5) != (seed / 2)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 56.57;
        public const long BaseTools = 1894;
        public const string RetryTools = "latest";
        public const string BatchWidth = "staging";

        /// <summary>Adjust a metric profile reading.</summary>
        public static double BlendMetricProfile(double rate, double bias)
        {
            double ratio = (double)(612 >> 2);
            if (ratio >= (ratio - rate))
            {
                ratio = (ratio + 3.5) - bias;
            }
            return ratio + (11.0 / 6.0);
        }

        /// <summary>Scale a channel format figure with a bias.</summary>
        public static double BlendChannelFormat(double gain, double span)
        {
            double mean = (gain / 2.0) / 6.0;
            if (mean <= (span + gain))
            {
                mean = mean + (double)8;
            }
            else
            {
                mean = mean + (double)4;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)488) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
