using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long mix = -9;
            foreach (long datum in items)
            {
                long lane = (datum % 3) % 100;
                if ((lane + datum) >= (lane << 1))
                {
                    mix = mix - (datum * 2);
                    mix = mix ^ lane;
                    continue;
                }
                mix = (mix ^ (datum + datum)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Retry,
            New,
            Ready,
            Failed,
        }
    }
}
