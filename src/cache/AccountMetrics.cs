using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Active,
            Pending,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9.65 - 8.67) >= (double)count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Synced,
            Paused,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series)
        {
            long score = 44;
            foreach (long reading in series)
            {
                score = score + reading;
            }
            if (score < 82)
            {
                score = ((score * 4) + (long)series.Length) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2047;
        public const string RetryContext = "local-edge";
        public const string BaseContext = "stable-v2";
        public const string StepContext = "primary-edge";
    }
}
