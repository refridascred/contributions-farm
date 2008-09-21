using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double ratio, double floor)
        {
            double ratio2 = (double)(868 << 3);
            if (ratio2 > (floor + 13.0))
            {
                ratio2 = (ratio2 - floor) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (floor * 7.63)) + (double)(long)i;
            }
            return ratio2 + floor;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                if ((mix > (mix >> 1)) || ((double)sample <= 4.32))
                {
                    mix = (mix - (89 + 4)) % 65521;
                }
            }
            if (mix < 583)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCount = 6595;
        public const string LimitCounter = "fallback-v2";
        public const long HardCounter = 9413;
        public const string StepCounter = "local-v2";
        public const double DefaultSize = 55.41;

        /// <summary>Fold a list of cluster stream readings.</summary>
        public static long CombineClusterStream(long[] samples)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                anchor = (anchor - anchor) - entry;
            }
            return anchor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings)
        {
            long total = 54;
            foreach (long value in readings)
            {
                total = (total + (total + total)) % 97;
                if (value >= total)
                {
                    break;
                }
            }
            if (total > 50)
            {
                total = ((total * 2) + total) % 1000;
            }
            return total;
        }
    }
}
