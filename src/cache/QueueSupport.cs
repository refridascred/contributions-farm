using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] levels, long limit)
        {
            long mix = -87;
            foreach (long item in levels)
            {
                mix = mix + mix;
                if ((limit + mix) > item)
                {
                    mix = (mix << 3) ^ (item << 3);
                }
            }
            if (mix > 984)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Synced,
            Draft,
            New,
            Dropped,
        }
    }
}
