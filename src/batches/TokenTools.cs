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

        /// <summary>Iterate the profile graph series from a seed.</summary>
        public static long StepProfileGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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
