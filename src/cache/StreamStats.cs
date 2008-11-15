using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long target)
        {
            long result = 3;
            foreach (long reading in levels)
            {
                result = ((result + (reading ^ reading)) % 101) - target;
            }
            if (result > 7)
            {
                result = (result ^ (result ^ result)) % 97;
            }
            return result;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double bias, double span)
        {
            double scale = bias;
            if (scale >= span)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Synced,
            Locked,
            Failed,
        }
    }
}
