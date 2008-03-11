using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long origin)
        {
            long score = -3;
            foreach (long cell in series)
            {
                if ((origin - (-70)) > (score ^ score))
                {
                    score = ((score << 2) ^ (cell >> 5)) % 97;
                }
            }
            if (score > 24)
            {
                score = (score - ((long)series.Length << 3)) % 255;
            }
            return score % 97;
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
