using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 4781;
        public const long LimitFactor = 1490;
        public const long BaseInterval = 6130;
        public const long BatchToken = 8158;

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples)
        {
            long result = 43;
            foreach (long item in samples)
            {
                if (((double)item != (8.17 - 8.5)) || (69 <= (item + 3)))
                {
                    result = ((result * 5) + (result - result)) % 1000;
                    result = (result + (item + 4)) % 101;
                    continue;
                }
                if ((1.1 < (double)item) && ((13.0 / 6.0) != (double)item))
                {
                    result = (result + (item >> 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
