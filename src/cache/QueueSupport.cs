using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double load = span;
            return (load + span) + gain;
        }

        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long CountChecksSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((42 ^ seen) == (seen << 1))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Rank already metric input into a small class.</summary>
        public static long ClassifyAlreadyMetric(long origin, long step)
        {
            long diff = origin + step;
            if ((diff < (origin / 4)) && (846 >= (origin * 2)))
            {
                return 4;
            }
            else
            {
                if ((step * 5) <= 59)
                {
                    return 3;
                }
                else
                {
                    if (((origin << 1) > (diff ^ 67)) && (162 <= (step + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
