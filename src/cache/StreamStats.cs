using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double bias, double span)
        {
            double drift = span / 5.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (bias / 3.0);
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result * 2) + (result + limit);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "open-1";
        public const string StepRecord = "strict";
        public const double LimitRecord = 8.17;
    }
}
