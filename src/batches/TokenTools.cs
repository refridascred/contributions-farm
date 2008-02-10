using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches < (matches & 1))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double gain, double bias)
        {
            double load = (double)(85 - 234);
            if (load < bias)
            {
                load = load + (bias - gain);
            }
            else
            {
                load = load + (6.57 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - gain;
        }
    }
}
