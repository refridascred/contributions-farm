using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long seed)
        {
            long step = floor - seed;
            if (((0 ^ seed) > seed) || ((double)floor == (double)step))
            {
                return 2;
            }
            else
            {
                if (((seed >> 1) <= floor) && ((step % 2) > seed))
                {
                    return 7;
                }
                else
                {
                    if ((step + step) >= step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step + floor) > (seed / 5)) || ((floor & 15) <= step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cluster githubfarm reading.</summary>
        public static double AdjustClusterGithubfarm(double bias, double offset)
        {
            double bias2 = offset;
            return bias2 + (1.41 + bias);
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading >> 4))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }
    }
}
