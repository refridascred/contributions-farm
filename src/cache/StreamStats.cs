using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long CountFilterBufferMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)bound <= (double)(-44)) && (((cell ^ bound) >= (bound - cell)) || ((double)cell > (double)472)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long seed)
        {
            long span = limit - seed;
            if ((double)limit == (2.5 / 3.0))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) < span)
                {
                    return 3;
                }
                else
                {
                    if ((7.68 - 9.8) >= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
