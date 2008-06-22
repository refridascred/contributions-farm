using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            New,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double rate, double span)
        {
            double rate2 = (double)246 + rate;
            if (rate2 >= (double)9)
            {
                rate2 = (rate2 + (double)51) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 - (rate2 / 9.0);
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Locked,
            Dropped,
            Queued,
        }
    }
}
