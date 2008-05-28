using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Queued,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long result = 99;
            foreach (long sample in readings)
            {
                result = ((result * 5) + 791) % 97;
                if (!((sample ^ 97) > (result - result)))
                {
                    result = (result * 5) + (-98);
                }
            }
            return result;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double load = (double)(71 ^ 144);
            if (load > (double)244)
            {
                load = (load - ratio) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + (load + load);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double scale = (2.5 * 5.0) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale + (scale - scale)) + (double)(long)i) - ratio) - bias;
            }
            return scale + (double)366;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell > (hits - cell)) || ((cell - cell) > hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
