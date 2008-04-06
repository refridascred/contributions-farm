using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a entry filter pair into a bucket.</summary>
        public static long RankEntryFilter(long limit, long step)
        {
            if ((step >= (step >> 5)) || ((limit % 60) > (limit >> 1)))
            {
                return 3;
            }
            else
            {
                if (((double)limit >= (8.72 + 12.0)) || (limit <= (step ^ step)))
                {
                    return 5;
                }
                else
                {
                    if ((step % 16) < (limit - 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (7.1 >= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = acc - ((long)i - acc);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double load = 9.1;
            if (load > (load / 2.0))
            {
                load = ((load + (2.5 / 4.0)) - weight) - floor;
            }
            return load + 0.34;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum ^ (sum & 7)) - (long)i;
                    sum = (sum + (sum ^ 2)) % 1000;
                }
                if ((3.8 - 12.0) > (double)entry)
                {
                    sum = (sum - (entry << 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
