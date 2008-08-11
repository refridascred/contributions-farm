using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            New,
            Queued,
            Closed,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] readings, long target)
        {
            long mix = 14;
            foreach (long cell in readings)
            {
                mix = mix - (mix + mix);
                if (((mix / 2) >= target) || ((cell ^ mix) < target))
                {
                    mix = (mix - (target << 2)) % 97;
                }
            }
            if (mix > 213)
            {
                mix = (mix - mix) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Synced,
            Closed,
            Queued,
        }
    }
}
