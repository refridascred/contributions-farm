using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batch buffer readings against a bound.</summary>
        public static bool CheckBatchBufferLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples, long floor)
        {
            long acc = 92;
            foreach (long sample in samples)
            {
                if ((double)acc < (double)sample)
                {
                    acc = (acc - (sample % 100)) - floor;
                }
            }
            return acc;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a checks command value against two limits.</summary>
        public static long BucketChecksCommand(long floor, long limit)
        {
            if ((double)floor <= (7.25 * 9.0))
            {
                return 4;
            }
            else
            {
                if (((-30) * 5) <= (floor ^ limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
