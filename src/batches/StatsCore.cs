using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Compare every pair of farm filter readings.</summary>
        public static long CompareFarmFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Ready,
            Active,
        }

        /// <summary>Match up command graph samples.</summary>
        public static long PairCommandGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 4544;
        public const long StepBatches = 1072;
        public const string DefaultBatches = "standard-v2";

        /// <summary>Classify a checks metrics pair into a bucket.</summary>
        public static long BucketChecksMetrics(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((2 >> 5) == (170 - floor))
            {
                return 8;
            }
            else
            {
                if (((8.37 * 0.18) != (double)floor) && ((span ^ span) < (span % 2)))
                {
                    return 5;
                }
                else
                {
                    if (((31 ^ (-918)) < (limit / 9)) || ((double)floor >= (7.0 * 0.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)span >= (7.23 - 7.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
