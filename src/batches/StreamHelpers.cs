using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two counter support measurements.</summary>
        public static double SmoothCounterSupport(double ratio, double span)
        {
            double rate = span;
            if (rate < (double)(-790))
            {
                rate = (rate - 6.19) - ratio;
            }
            return rate - (double)2;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((1.0 + 19.0) == (double)origin))
                {
                    anchor = (anchor ^ origin) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + (origin + origin)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "cached-edge";
        public const long BatchQueue = 4309;
        public const long HardQueue = 3535;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((bound - 14) <= origin)
            {
                return 5;
            }
            else
            {
                if (origin < 877)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin == (17.0 + 13.0)) || (13.0 < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            New,
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long MeasureSessionContributiHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((69 % 100) != (count * 3))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
