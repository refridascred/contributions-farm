using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate schema counter samples.</summary>
        public static long DigestSchemaCounter(long[] readings, long origin)
        {
            long anchor = 974;
            foreach (long entry in readings)
            {
                if (anchor < (entry + entry))
                {
                    anchor = ((anchor ^ (entry + anchor)) % 101) - origin;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally & 63) < tally)
                {
                    tally = ((tally + 2) ^ sample) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
