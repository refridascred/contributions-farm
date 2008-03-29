using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long CountBatchChannelMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading >= (364 + reading))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi route entry stays within the limit.</summary>
        public static bool GuardContributiRouteRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
