using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double span)
        {
            double weight = gain;
            return (weight - (double)109) + span;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) == (cell + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metric checks entries that pass the check.</summary>
        public static long CountMetricChecksOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen + 9) > (273 / 3)) && ((long)readings.Length >= (seen + step)))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
