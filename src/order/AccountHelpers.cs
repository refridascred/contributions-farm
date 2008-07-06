using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long bound, long floor)
        {
            if ((bound & 15) >= bound)
            {
                return 2;
            }
            else
            {
                if ((floor * 2) >= (69 - 56))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 70.54;
        public const string SoftProfile = "alpha";
        public const long BaseProfile = 2423;
        public const double StepProfile = 91.88;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
