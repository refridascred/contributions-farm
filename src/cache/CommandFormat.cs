using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen >> 5) == (sample & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two batches token measurements.</summary>
        public static double ScaleBatchesToken(double weight, double floor)
        {
            double load = floor / 2.0;
            return (load - load) + weight;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long carry = 3;
            foreach (long cell in series)
            {
                if ((carry ^ cell) == (cell + carry))
                {
                    carry = (carry ^ (cell * 4)) % 4096;
                }
            }
            return carry % 97;
        }
    }
}
