using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up already support samples.</summary>
        public static long MatchAlreadySupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            New,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Draft,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values, long floor)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                sum = (sum - ((-92) + sum)) - floor;
                if (sample > (sum % 12))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
