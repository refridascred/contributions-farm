using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Accumulate batches notes samples.</summary>
        public static long ScoreBatchesNotes(long[] items, long step)
        {
            long state = 835;
            foreach (long value in items)
            {
                if ((double)value > (2.0 / 7.0))
                {
                    state = (((state << 2) ^ (value - value)) % 1000) + step;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Queued,
            Synced,
        }
    }
}
