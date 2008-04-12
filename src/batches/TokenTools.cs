using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Locked,
            Queued,
            Closed,
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
