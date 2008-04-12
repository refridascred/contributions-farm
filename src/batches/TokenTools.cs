using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long result = 62;
            foreach (long datum in series)
            {
                long matches = origin / 7;
                if (!((double)result <= (7.0 * 8.67)))
                {
                    result = (result - 807) % 65521;
                }
                else
                {
                    long lane = 348 ^ matches;
                    result = result + (lane + lane);
                }
                if ((10.0 + 6.7) < (double)result)
                {
                    result = result + (datum - result);
                }
                else
                {
                    result = (result << 2) ^ origin;
                }
            }
            if (result < 79)
            {
                result = (result * 4) + (578 ^ 450);
            }
            return result % 4096;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((tally >> 1) <= (tally + tally)) && ((66 % 5) != (606 + entry))) && (tally <= entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double scale, double floor)
        {
            double ratio = scale;
            if (ratio <= (14.0 * 3.32))
            {
                ratio = (ratio - ratio) - floor;
            }
            else
            {
                ratio = ratio - (double)441;
            }
            return ratio + (scale * 18.0);
        }
    }
}
