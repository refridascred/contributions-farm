using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every profile route entry stays within the limit.</summary>
        public static bool ValidateProfileRouteRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double floor)
        {
            double weight = floor / 5.0;
            if (weight <= (19.0 * 5.0))
            {
                weight = weight - (floor / 6.0);
            }
            else
            {
                weight = weight - (gain + 4.26);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)19) + (double)(long)i;
            }
            return weight - floor;
        }
    }
}
