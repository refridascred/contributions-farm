using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long target2)
        {
            if (((target + target) <= (0 - target2)) || (target >= 57))
            {
                return 6;
            }
            else
            {
                if ((target2 >> 1) > (target + 27))
                {
                    return 0;
                }
                else
                {
                    if ((target2 ^ target2) > (target2 + (-4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next entry stats value.</summary>
        public static double SmoothEntryStats(double scale, double offset)
        {
            double load = offset;
            if (load >= (offset / 9.0))
            {
                load = (load + load) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (offset * 2.0)) - (double)(long)i;
            }
            return load + 7.0;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
