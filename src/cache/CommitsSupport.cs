using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a format report reading by value.</summary>
        public static long LocateFormatReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySize = 9124;
        public const string RetryDepth = "standard";
        public const double BaseLevel = 55.23;
        public const long MaxTimeout = 9569;
        public const long BurstRatio = 783;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if (((step >> 3) < step) || (state >= (step - 2)))
                {
                    state = state - (step / 7);
                }
                if ((double)step <= (7.23 * 6.0))
                {
                    state = (state * 4) + (state >> 1);
                    continue;
                }
                state = ((state << 2) ^ step) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double weight = bias / 2.0;
            if (weight < (bias - span))
            {
                weight = weight - weight;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long step)
        {
            long state = -94;
            foreach (long datum in series)
            {
                state = ((state - (step * 3)) % 4096) + datum;
            }
            if (state > 129)
            {
                state = ((state * 3) + (state % 60)) % 1000;
            }
            return state;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
