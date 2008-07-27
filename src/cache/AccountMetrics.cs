using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 5448;
        public const double StepWindow = 93.06;
        public const long RetryDepth = 1788;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches << 3) >= (item + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long bound2)
        {
            if ((bound + bound2) <= (bound2 << 1))
            {
                return 6;
            }
            else
            {
                if (bound <= (bound2 + 8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 3771;
        public const string CacheEditor = "standard-edge";
        public const double MaxSize = 21.39;

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
