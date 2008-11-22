using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (gain - offset)) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches <= 10.0)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
