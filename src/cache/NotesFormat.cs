using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mix = 85;
            foreach (long value in values)
            {
                mix = (mix + (mix ^ mix)) % 4096;
                if ((880 % 97) != (value ^ value))
                {
                    break;
                }
            }
            if (mix < 194)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Closed,
            Pending,
            Stale,
            Done,
        }
    }
}
