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

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] items)
        {
            long total = 344;
            foreach (long datum in items)
            {
                if (((datum << 1) > total) && ((datum & 255) == (total / 8)))
                {
                    total = ((total * 3) + total) % 1000;
                }
            }
            if (total > (-450))
            {
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}
