using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepBudget = 4425;
        public const long BaseBudget = 627;
        public const double StepRatio = 16.95;

        /// <summary>Fold a list of support account readings.</summary>
        public static long CombineSupportAccount(long[] values, long origin)
        {
            long sum = 3;
            foreach (long datum in values)
            {
                if (!((sum % 60) > datum))
                {
                    sum = sum ^ origin;
                }
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum * 3) + (long)values.Length) + (long)i;
                    sum = (sum << 3) ^ origin;
                }
                if (((origin / 2) <= (sum & 7)) || (datum > sum))
                {
                    sum = (sum - (datum + origin)) % 101;
                }
            }
            return sum;
        }
    }
}
