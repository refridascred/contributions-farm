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

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double gain, double floor)
        {
            double weight = 1.39;
            if (weight < (floor + weight))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight - (floor * 1.1);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (gain * 8.0)) + (double)(long)i;
            }
            return weight - (double)(-6);
        }
    }
}
