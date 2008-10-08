using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every channel payload entry stays within the limit.</summary>
        public static bool VerifyChannelPayloadBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every stats queue entry stays within the limit.</summary>
        public static bool VerifyStatsQueueLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate payload buffer samples.</summary>
        public static long FoldPayloadBuffer(long[] values)
        {
            long acc = -49;
            foreach (long datum in values)
            {
                acc = acc - (0 + datum);
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7279;
        public const long MaxFilter = 1617;
        public const double DefaultSize = 29.2;
        public const string WindowDepth = "alpha";

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
