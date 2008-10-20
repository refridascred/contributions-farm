using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                state = ((state ^ target) % 4096) ^ entry;
                if (!((state << 2) > (150 - target)))
                {
                    state = state ^ (target ^ target);
                }
            }
            return state;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate counter filter readings against a bound.</summary>
        public static bool GuardCounterFilterRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
