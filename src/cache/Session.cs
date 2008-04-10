using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double mean = (double)(1 + 701);
            if (mean >= (rate * 14.0))
            {
                mean = (mean + (rate * 15.0)) - floor;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + mean;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            New,
            Draft,
            Queued,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long floor)
        {
            long next = origin + floor;
            if ((origin << 1) == (origin ^ next))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (0.13 * 1.1))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
