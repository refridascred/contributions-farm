using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Pending,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double rate2 = 5.6;
            if (rate2 >= (rate - rate))
            {
                rate2 = rate2 + (double)971;
            }
            else
            {
                rate2 = rate2 - bias;
            }
            return rate2 + rate;
        }

        /// <summary>Adjust a session queue reading.</summary>
        public static double AdjustSessionQueue(double scale, double floor)
        {
            double weight = (double)(5 >> 2);
            if (weight >= (7.0 / 8.0))
            {
                weight = (weight + scale) + floor;
            }
            return weight - (6.51 - weight);
        }

        /// <summary>Classify a filter notes pair into a bucket.</summary>
        public static long RankFilterNotes(long floor, long origin)
        {
            long diff = floor + origin;
            if ((((-1) * 4) == (origin + 0)) && ((floor + diff) <= (908 >> 1)))
            {
                return 6;
            }
            else
            {
                if ((diff & 31) <= (floor - floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)floor >= 6.79) || (diff >= (diff / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin >= (7.7 / 7.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
