using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a cluster filter figure with a bias.</summary>
        public static double ProjectClusterFilter(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)(long)i) + bias;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + hits) < hits)
                {
                    hits = ((hits + 3) + datum) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long limit)
        {
            long sum = 414;
            foreach (long entry in levels)
            {
                sum = ((((sum << 2) ^ ((-288) & 1)) % 4096) + entry) - limit;
            }
            if (sum < 82)
            {
                sum = (sum + (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Active,
            Draft,
            Pending,
        }
    }
}
