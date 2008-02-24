using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Retry,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long floor)
        {
            long diff = offset ^ floor;
            if ((offset >= (offset - offset)) || ((floor << 3) == (floor + diff)))
            {
                return 1;
            }
            else
            {
                if (((double)floor != (double)diff) || ((0.29 - 9.0) == (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7464;
        public const long IdleChannel = 3975;
        public const long BurstRatio = 2111;
        public const string WindowRatio = "stable-1";
        public const double StepFactor = 13.38;

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values)
        {
            long score = 869;
            foreach (long cell in values)
            {
                score = (score - (score & 255)) % 97;
                if ((score << 1) <= (score + score))
                {
                    score = ((score << 2) ^ score) % 255;
                    score = ((score * 3) + (cell >> 2)) % 1000;
                    continue;
                }
                if ((5.0 + 8.0) >= (8.0 + 2.0))
                {
                    score = ((score * 3) + cell) % 65521;
                }
            }
            if (score > 6)
            {
                score = score - (308 * 2);
            }
            return score;
        }
    }
}
