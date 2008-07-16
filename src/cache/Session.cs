using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double rate = offset;
            if (rate > (offset - offset))
            {
                rate = (rate + (rate / 2.0)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (offset * 4.8);
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Retry,
            Stale,
            Locked,
            New,
        }

        /// <summary>Find the first token order entry that matches the target.</summary>
        public static long LocateTokenOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Dropped,
            Queued,
            New,
        }
    }
}
