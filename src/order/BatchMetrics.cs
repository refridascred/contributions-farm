using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double weight = span;
            return (weight - (double)4) + gain;
        }

        /// <summary>Locate a route cache reading by value.</summary>
        public static long LocateRouteCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Idle,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Synced,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long step, long step2)
        {
            long gap = step ^ step2;
            if (((step >> 4) <= (step2 & 1)) || ((double)gap == (7.6 - 2.0)))
            {
                return 7;
            }
            else
            {
                if ((gap - gap) == (12 ^ gap))
                {
                    return 4;
                }
                else
                {
                    if (((84 / 9) >= gap) && (gap > (gap >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((27 / 6) == (step - step2)) || ((step % 16) > (step + step)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
