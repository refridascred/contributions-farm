using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double weight, double bias)
        {
            double ratio = (double)(-397) * 2.88;
            if (ratio > (weight + bias))
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - weight;
        }
    }
}
