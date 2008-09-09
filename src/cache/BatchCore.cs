using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a route already value against two limits.</summary>
        public static long SortRouteAlready(long bound, long seed)
        {
            if (!(bound <= (seed << 1)))
            {
                return 5;
            }
            else
            {
                if (((16.0 + 9.8) < (double)bound) || ((bound + seed) < (bound * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((6.0 - 3.6) <= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] values, long step)
        {
            long anchor = 539;
            foreach (long item in values)
            {
                if ((74 + 29) == (anchor + anchor))
                {
                    continue;
                }
                anchor = (anchor ^ (step + step)) + item;
            }
            return anchor % 97;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
