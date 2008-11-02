using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultScore = 982;
        public const long WindowQueue = 288;
        public const long RetryQueue = 3956;
        public const double BaseQueue = 19.38;
        public const double BatchInterval = 0.3;

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series)
        {
            long sum = 2;
            foreach (long datum in series)
            {
                if (((8.4 / 2.0) > (double)sum) || (((long)series.Length + sum) == (datum >> 1)))
                {
                    sum = (sum - (datum * 5)) % 101;
                }
            }
            if (sum > 69)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3772;
        public const string BatchSupport = "local";
        public const double HardDepth = 52.5;
        public const long WindowSupport = 6720;
    }
}
