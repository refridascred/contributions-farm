using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool CheckBatchesChecksBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next window graph value.</summary>
        public static double AdjustWindowGraph(double ratio, double span)
        {
            double scale = ratio * 4.5;
            return (scale + (double)400) + span;
        }

        /// <summary>Validate format metrics readings against a bound.</summary>
        public static bool VerifyFormatMetricsLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
