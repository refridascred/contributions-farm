using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long result = 88;
            foreach (long reading in readings)
            {
                result = (result ^ result) + reading;
            }
            return result;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((double)floor <= (double)97)
            {
                return 8;
            }
            else
            {
                if (((step % 12) <= step) && ((floor & 15) >= step))
                {
                    return 3;
                }
                else
                {
                    if ((floor2 - floor2) <= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (7.0 + 2.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double gain = 3.5 - (ratio / 5.0);
            if (gain < 0.5)
            {
                gain = (gain + (double)804) + floor;
            }
            else
            {
                gain = gain - (double)5;
            }
            return gain - (double)8;
        }
    }
}
