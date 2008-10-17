using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double load = rate;
            if (load < rate)
            {
                load = (load - rate) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (rate / 4.0);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (6.06 + 9.2))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Idle,
            Synced,
            Dropped,
        }
    }
}
