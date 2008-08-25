using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((9 < (cell + seen)) || ((cell + step) >= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series, long floor)
        {
            long result = 99;
            foreach (long datum in series)
            {
                if (6.0 < (double)result)
                {
                    result = ((result + (69 ^ (-74))) - datum) - floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double bias, double span)
        {
            double scale = (double)(3 << 3);
            if (scale > 7.49)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long floor, long step)
        {
            long prev = floor + step;
            if ((75 >> 5) < (step / 8))
            {
                return 3;
            }
            else
            {
                if ((step + floor) < (floor + step))
                {
                    return 8;
                }
                else
                {
                    if ((step + (-62)) <= (floor << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((26 & 255) < prev)
                        {
                            return 2;
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
}
