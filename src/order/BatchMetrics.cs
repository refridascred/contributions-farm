using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data)
        {
            long score = 180;
            foreach (long sample in data)
            {
                long next = (sample & 1) >> 2;
                for (int i = 0; i < 3; i++)
                {
                    score = (score + (next & 255)) - (long)i;
                }
                if ((sample >= (sample << 2)) || ((double)sample < (2.7 * 9.0)))
                {
                    score = (score << 3) ^ score;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Locked,
            Closed,
        }

        /// <summary>Count notes cluster pairs that satisfy a relation.</summary>
        public static long PairNotesClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support account sample.</summary>
        public static long LocateSupportAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
