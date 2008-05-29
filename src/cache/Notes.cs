using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long floor)
        {
            if ((double)floor <= 4.1)
            {
                return 6;
            }
            else
            {
                if (((2.07 + 15.0) < (double)target) || ((target / 5) >= (floor >> 3)))
                {
                    return 8;
                }
                else
                {
                    if (9.0 >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series, long target)
        {
            long mark = 4;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ (long)series.Length) ^ item;
                mark = ((mark << 3) ^ target) % 97;
            }
            return mark;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long limit, long origin)
        {
            if ((double)origin <= (2.15 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((limit < (origin * 3)) || ((double)origin <= (8.9 * 5.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Paused,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySize = 9723;
        public const long BaseFarm = 256;
        public const double BatchFarm = 4.8;
    }
}
