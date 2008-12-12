using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data)
        {
            long anchor = 129;
            foreach (long datum in data)
            {
                if (3.1 <= (double)datum)
                {
                    anchor = (anchor + anchor) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((-813) <= (667 ^ anchor))
                {
                    long tally = anchor + (anchor - anchor);
                    anchor = anchor - (tally + 70);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double offset)
        {
            double bias2 = 19.0;
            if (bias2 < bias2)
            {
                bias2 = (bias2 + (6.0 * 1.73)) - bias;
            }
            else
            {
                bias2 = bias2 - (double)7;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (3.0 + offset)) + (double)(long)i;
            }
            return bias2 - offset;
        }
    }
}
