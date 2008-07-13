using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((lane >= (lane + lane)) && ((seed & 1) <= floor))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((71 < (seed << 3)) || (floor > (floor - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(lane <= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double span)
        {
            double gain = (double)(99 + 6);
            if (gain > gain)
            {
                gain = (gain - (gain + 4.0)) - span;
            }
            else
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(value < (value + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long target)
        {
            if ((19.0 * 17.0) <= (double)target)
            {
                return 5;
            }
            else
            {
                if (target < (target >> 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 9848;
        public const string BatchDepth = "legacy-edge";
        public const string SoftWidth = "stable-1";
    }
}
