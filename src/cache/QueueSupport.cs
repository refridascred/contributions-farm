using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardLevel = 9116;
        public const long WindowSize = 8634;
        public const double MaxBuffer = 80.18;
        public const string WindowBuffer = "standard-v2";

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((((-612) + matches) >= floor) || ((reading / 6) != (matches + floor))) && !((matches + floor) != (reading + 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double weight, double floor)
        {
            double ratio = 5.1 * 4.8;
            if (ratio < (weight / 6.0))
            {
                ratio = ratio + (floor + 2.0);
            }
            else
            {
                ratio = ratio + (floor * 19.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - (double)79;
        }
    }
}
