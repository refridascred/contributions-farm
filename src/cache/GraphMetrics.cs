using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Blend two profile stats measurements.</summary>
        public static double SmoothProfileStats(double scale, double bias)
        {
            double ratio = scale / 4.0;
            if (ratio >= scale)
            {
                ratio = ratio - scale;
            }
            return ratio - bias;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long limit)
        {
            if ((double)limit <= (3.0 / 3.0))
            {
                return 1;
            }
            else
            {
                if ((limit << 3) != (1 + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((71 + target) > target)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
