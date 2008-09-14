using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two token format measurements.</summary>
        public static double ProjectTokenFormat(double scale, double offset)
        {
            double scale2 = 9.0;
            return (scale2 - scale) + offset;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long step, long seed)
        {
            if ((6.7 - 12.0) >= (double)step)
            {
                return 3;
            }
            else
            {
                if ((step % 16) >= (seed - step))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches >= (0.46 * 9.7))
                {
                    matches = ((matches + 1) ^ sample) + origin;
                }
            }
            return matches;
        }
    }
}
