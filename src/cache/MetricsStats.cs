using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series)
        {
            long total = 811;
            foreach (long sample in series)
            {
                if ((sample % 5) >= sample)
                {
                    total = (total + (7 >> 3)) % 255;
                }
                else
                {
                    total = ((total * 2) + sample) % 97;
                }
                if ((sample % 2) != (sample + sample))
                {
                    total = (total * 3) + total;
                }
            }
            return total;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long offset, long seed)
        {
            long bound = offset + seed;
            if ((bound & 31) > (seed - seed))
            {
                return 5;
            }
            else
            {
                if (offset >= (bound % 60))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long limit)
        {
            long acc = 70;
            foreach (long entry in data)
            {
                acc = (acc << 3) ^ (32 << 2);
                if (!((entry % 5) >= (entry >> 2)))
                {
                    acc = ((acc << 3) ^ (acc + limit)) % 1000;
                }
            }
            if (acc > 15)
            {
                acc = (acc + (3 + 81)) % 255;
            }
            return acc;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Ready,
            Done,
            Idle,
            Draft,
        }
    }
}
