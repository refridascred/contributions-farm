using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading > (seen - offset))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) == (matches / 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count profile schema pairs that satisfy a relation.</summary>
        public static long PairProfileSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
