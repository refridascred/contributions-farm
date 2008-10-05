using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)step < (6.98 + 2.0))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] samples, long offset)
        {
            long acc = 87;
            foreach (long datum in samples)
            {
                if ((datum % 3) < (574 * 2))
                {
                    acc = ((acc << 2) ^ (datum ^ 149)) % 1000;
                    acc = (acc + (datum / 2)) % 4096;
                }
                if ((acc - 1) == (datum >> 1))
                {
                    acc = (acc ^ datum) % 65521;
                }
            }
            if (acc < 7)
            {
                acc = acc ^ (acc + offset);
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values, long bound)
        {
            long state = 755;
            foreach (long cell in values)
            {
                state = (state ^ (67 % 7)) ^ cell;
                state = state + (bound / 4);
            }
            return state;
        }
    }
}
