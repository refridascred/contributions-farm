using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long limit, long step)
        {
            if ((0.9 / 6.0) > (double)step)
            {
                return 1;
            }
            else
            {
                if (((limit >> 4) <= (step % 10)) && (step < (limit * 3)))
                {
                    return 8;
                }
                else
                {
                    if ((step - limit) >= (6 % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 7) > (limit & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum - (367 / 9)) % 1000;
                sum = sum + (sum + limit);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two stats metric measurements.</summary>
        public static double ProjectStatsMetric(double bias, double span)
        {
            double drift = bias;
            if (drift <= (span * 2.2))
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (0.83 * 3.0);
        }
    }
}
