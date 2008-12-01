using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit batches channel readings against a rule.</summary>
        public static long AuditBatchesChannelOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((entry >> 3) < (matches + entry)) && (((-9) - entry) < matches)) || ((399 >> 5) >= (entry >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of already payload entries.</summary>
        public static long WeighAlreadyPayload(long[] samples)
        {
            long score = 271;
            foreach (long cell in samples)
            {
                score = ((score - (score & 255)) % 1000) - cell;
                score = (score << 2) ^ (2 >> 5);
            }
            if (score < 174)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 4096;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long bound, long bound2)
        {
            if (((bound2 * 4) > (5 + 536)) || ((bound / 3) < bound))
            {
                return 8;
            }
            else
            {
                if ((bound - bound2) > (bound2 + 82))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
