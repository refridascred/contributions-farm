using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long bound2)
        {
            if (bound2 < (bound / 3))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) <= bound2)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two notes route measurements.</summary>
        public static double SmoothNotesRoute(double weight, double floor)
        {
            double load = (double)(291 + 352);
            if (load >= weight)
            {
                load = load - (load - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)81) - (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Digest a series of schema buffer entries.</summary>
        public static long CombineSchemaBuffer(long[] values, long origin)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = ((mix << 3) ^ (sample & 3)) % 97;
                if ((double)origin < 0.8)
                {
                    mix = mix - mix;
                }
                if (22 >= origin)
                {
                    mix = (mix ^ (2 & 255)) % 1000;
                }
            }
            return mix % 1000;
        }
    }
}
