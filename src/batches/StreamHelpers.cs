using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a metric token value against two limits.</summary>
        public static long SortMetricToken(long limit, long seed)
        {
            if (limit >= (limit + seed))
            {
                return 4;
            }
            else
            {
                if ((9 < (seed << 3)) && ((seed & 127) >= (seed + seed)))
                {
                    return 1;
                }
                else
                {
                    if ((2 ^ limit) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheFactor = 9634;
        public const double WindowBatches = 94.46;
        public const double BurstBatches = 21.88;
        public const double StepBatches = 75.98;

        /// <summary>Count channel profile pairs that satisfy a relation.</summary>
        public static long MatchChannelProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values, long limit)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = (((anchor * 2) + (limit % 64)) % 97) - datum;
            }
            if (anchor < (-51))
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 206;
        public const long BaseEntry = 2792;
        public const double LimitEntry = 34.74;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
