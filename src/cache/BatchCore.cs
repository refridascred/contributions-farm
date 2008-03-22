using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxSize = 687;
        public const long LimitChecks = 2466;
        public const long MinChecks = 9346;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double rate, double offset)
        {
            double gain = 9.8;
            if (gain <= (gain + rate))
            {
                gain = gain - (offset / 3.0);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + 7.07) + (double)(long)i;
            }
            return gain + (rate / 6.0);
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
