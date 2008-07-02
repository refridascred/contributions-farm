using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                if ((total >> 5) <= step)
                {
                    total = (total ^ step) % 4096;
                }
                else
                {
                    total = total + (total & 31);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long target)
        {
            if ((bound & 15) > bound)
            {
                return 1;
            }
            else
            {
                if (target < (8 - bound))
                {
                    return 4;
                }
                else
                {
                    if (bound > (22 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)target >= (double)0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
