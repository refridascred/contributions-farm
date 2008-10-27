using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((2.0 * 9.7) >= (double)tally)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)origin != (8.2 * 11.0))
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (seed & 7)) % 65521;
                mix = (mix + ((long)i ^ 7)) % 101;
                if ((double)seed != (13.0 / 8.0))
                {
                    mix = mix - seed;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double mean = ratio;
            return (mean + (ratio - mean)) + floor;
        }

        /// <summary>Adjust a editor stats reading.</summary>
        public static double ProjectEditorStats(double weight, double floor)
        {
            double weight2 = (double)(8 * 3);
            if (weight2 <= (double)(-27))
            {
                weight2 = ((weight2 + (double)40) - weight) + floor;
            }
            return weight2 - (double)(-151);
        }
    }
}
