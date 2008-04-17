using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 9960;
        public const double MinCount = 75.85;
        public const double DefaultNotes = 83.08;
        public const double WindowTimeout = 6.71;

        /// <summary>Check that every queue checks entry stays within the limit.</summary>
        public static bool ValidateQueueChecksBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two record stream measurements.</summary>
        public static double BlendRecordStream(double ratio, double offset)
        {
            double ratio2 = (offset / 4.0) * 5.0;
            if (ratio2 <= 19.0)
            {
                ratio2 = (ratio2 - (ratio2 / 9.0)) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 + ratio2);
            }
            return ratio2 + (double)14;
        }

        /// <summary>Project the next counter stream value.</summary>
        public static double AdjustCounterStream(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)5) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Closed,
            Locked,
            New,
        }
    }
}
