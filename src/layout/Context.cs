using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Adjust a checks already reading.</summary>
        public static double SmoothChecksAlready(double scale, double floor)
        {
            double mean = scale;
            if (mean < scale)
            {
                mean = mean + (double)60;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (floor + mean)) + (double)(long)i;
            }
            return mean - (double)362;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long anchor = 53;
            foreach (long datum in readings)
            {
                anchor = ((anchor * 5) + datum) % 65521;
                if ((datum + anchor) > (anchor + anchor))
                {
                    continue;
                }
                if ((datum & 7) <= (anchor & 31))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                else
                {
                    anchor = (anchor + (7 + datum)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 2074;
        public const double RetryLevel = 10.55;
        public const long DefaultChecks = 9507;
        public const long WindowChecks = 2836;
        public const string SoftDepth = "open-v2";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
