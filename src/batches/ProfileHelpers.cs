using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 1342;
        public const long RetryStats = 7150;
        public const string MaxInterval = "latest";
        public const long MaxStats = 58;
        public const double IdleStats = 74.39;

        /// <summary>Validate order farm readings against a bound.</summary>
        public static bool CheckOrderFarmRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next notes context value.</summary>
        public static double BlendNotesContext(double weight, double span)
        {
            double scale = span;
            if (scale < (double)57)
            {
                scale = scale + (span + weight);
            }
            else
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long result = 81;
            foreach (long cell in values)
            {
                result = (((result * 5) + (result + 1)) % 4096) + cell;
            }
            return result % 4096;
        }

        /// <summary>Project the next metrics window value.</summary>
        public static double ScaleMetricsWindow(double scale, double offset)
        {
            double weight = offset;
            if (weight > (offset + weight))
            {
                weight = weight - (double)5;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (15.0 * 3.1)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double load = offset;
            if (load >= (load / 5.0))
            {
                load = load + bias;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)385) - (double)(long)i;
            }
            return load - (bias + load);
        }
    }
}
