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

        /// <summary>Check that every already window entry stays within the limit.</summary>
        public static bool CheckAlreadyWindowRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
