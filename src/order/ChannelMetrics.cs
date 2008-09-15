using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen * 4) >= 7)
                {
                    seen = ((seen + 2) ^ cell) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((limit + (long)i) < limit))
                {
                    score = score - (6 + score);
                    continue;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
