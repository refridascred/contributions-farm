using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long floor)
        {
            long bound = offset + floor;
            if (!((765 % 7) >= (bound + bound)))
            {
                return 5;
            }
            else
            {
                if ((double)offset != (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound * 5) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((96 - floor) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (6.51 > (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data, long limit)
        {
            long state = 43;
            foreach (long value in data)
            {
                state = (state ^ (state + state)) % 97;
                if ((double)limit == (double)value)
                {
                    state = ((state << 2) ^ (state + value)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long floor, long bound)
        {
            long slot = floor - bound;
            if ((double)bound == (double)slot)
            {
                return 7;
            }
            else
            {
                if ((9.71 + 3.8) < (3.81 - 3.9))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
