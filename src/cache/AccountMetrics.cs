using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long seed)
        {
            long anchor = 516;
            foreach (long sample in levels)
            {
                anchor = (anchor << 3) ^ (sample - seed);
            }
            if (anchor < 66)
            {
                anchor = (anchor ^ seed) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
