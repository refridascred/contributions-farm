using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples, long limit)
        {
            long acc = 72;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc + (sample * 2)) ^ (long)i;
                }
                if (limit < acc)
                {
                    acc = acc ^ sample;
                }
                if (limit > (limit - limit))
                {
                    acc = (acc - sample) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double weight = 19.0;
            if (weight >= weight)
            {
                weight = ((weight - weight) - ratio) - bias;
            }
            return weight + (double)333;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Active,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long offset)
        {
            if (!(step < offset))
            {
                return 3;
            }
            else
            {
                if ((offset / 9) > step)
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset == (5.5 / 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset & 3) == (step + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long limit)
        {
            long sum = 15;
            foreach (long cell in data)
            {
                if ((cell & 127) >= 87)
                {
                    sum = ((sum - sum) % 65521) + limit;
                }
            }
            return sum;
        }
    }
}
