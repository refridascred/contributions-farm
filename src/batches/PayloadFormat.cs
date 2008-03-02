using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double load = scale * 2.52;
            if (load >= load)
            {
                load = load - (span - scale);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (scale * 5.48)) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Rank filter cache input into a small class.</summary>
        public static long GradeFilterCache(long floor, long step)
        {
            if (step <= (floor / 3))
            {
                return 2;
            }
            else
            {
                if (floor > ((-92) >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((floor + step) > step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (seed >= (sample - seed))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
