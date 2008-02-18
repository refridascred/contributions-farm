using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double drift = 4.0;
            if (drift <= (drift * 18.0))
            {
                drift = (drift + offset) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - 16.0;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 12.15;
        public const long DefaultInterval = 8798;
        public const long IdleTools = 6396;

        /// <summary>Rank layout stream input into a small class.</summary>
        public static long GradeLayoutStream(long seed, long origin)
        {
            long diff = seed + origin;
            if (diff >= (diff - origin))
            {
                return 6;
            }
            else
            {
                if (!((282 >> 5) >= (diff / 6)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((double)value < (3.1 + 4.2)) && ((64 + (-73)) == (value - (long)data.Length)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen >> 1) > (seen + seen))
                {
                    seen = ((seen + 3) ^ sample) - limit;
                }
            }
            return seen;
        }
    }
}
