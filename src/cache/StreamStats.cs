using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Ready,
            New,
            Paused,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Synced,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double rate = (double)(-296) - (bias + bias);
            if (rate <= (double)72)
            {
                rate = (rate - (double)410) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (rate * 6.48)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
