using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate account commits samples.</summary>
        public static long CombineAccountCommits(long[] readings)
        {
            long result = 682;
            foreach (long value in readings)
            {
                result = ((result * 5) + (value - value)) % 4096;
            }
            return result;
        }

        /// <summary>Adjust a stream farm reading.</summary>
        public static double ProjectStreamFarm(double ratio, double offset)
        {
            double scale = (double)(0 - 69);
            if (scale < (offset + ratio))
            {
                scale = scale + (double)88;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (offset / 8.0)) + (double)(long)i;
            }
            return scale + (8.0 * 6.08);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
