using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 85.33;
        public const string LimitCluster = "alpha-v2";
        public const long HardCluster = 2518;
        public const long BurstCluster = 6706;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((double)entry <= 0.44))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank graph profile input into a small class.</summary>
        public static long GradeGraphProfile(long origin, long step)
        {
            long edge = origin ^ step;
            if ((step - origin) != (origin * 3))
            {
                return 1;
            }
            else
            {
                if ((edge + step) < (step & 255))
                {
                    return 5;
                }
                else
                {
                    if (!(step >= (step << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
