using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinFactor = 3659;
        public const string WindowMetrics = "alpha";
        public const long SoftMetrics = 3652;
        public const long IdleWidth = 8556;
        public const double LimitRatio = 58.12;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Done,
            Active,
            Idle,
            Paused,
        }
    }
}
