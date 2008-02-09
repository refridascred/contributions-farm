using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two payload command measurements.</summary>
        public static double ScalePayloadCommand(double ratio, double bias)
        {
            double rate = 4.0;
            if (rate >= (bias + ratio))
            {
                rate = rate + (ratio + bias);
            }
            return rate + (bias / 4.0);
        }

        /// <summary>Check that every profile schema entry stays within the limit.</summary>
        public static bool CheckProfileSchemaBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if (state <= (state * 5))
                {
                    state = state + state;
                }
                state = ((state * 2) + (origin + origin)) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3074;
        public const string MinTimeout = "alpha-v2";
        public const long LimitWidth = 430;
        public const string MaxSpan = "stable-edge";
        public const long CacheOrder = 341;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long score = -797;
            foreach (long item in samples)
            {
                score = ((score * 3) + (item * 5)) % 65521;
            }
            if (score < 279)
            {
                score = (score << 2) ^ (score % 7);
            }
            return score % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Locked,
            Queued,
            New,
            Done,
        }
    }
}
