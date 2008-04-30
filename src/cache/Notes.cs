using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double ratio = (double)(55 - 56);
            if (ratio <= (gain / 6.0))
            {
                ratio = (ratio - ratio) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Check that every counter entry entry stays within the limit.</summary>
        public static bool VerifyCounterEntryBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((55 % 16) <= ((long)levels.Length + (long)levels.Length)) && (seen < (bound << 3)))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
