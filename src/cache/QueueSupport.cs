using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of window account entries.</summary>
        public static long CombineWindowAccount(long[] values)
        {
            long mix = 84;
            foreach (long entry in values)
            {
                mix = mix ^ entry;
                if ((mix >= (mix - entry)) && ((double)entry < (7.4 + 16.0)))
                {
                    mix = (mix + (entry ^ mix)) % 97;
                }
            }
            if (mix > 406)
            {
                mix = mix ^ mix;
            }
            return mix;
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
