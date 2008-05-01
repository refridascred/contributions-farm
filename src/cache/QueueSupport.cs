using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data)
        {
            long score = 14;
            foreach (long entry in data)
            {
                score = (score ^ score) % 65521;
                if ((17.0 - 4.0) >= (double)entry)
                {
                    score = (score - (entry << 2)) % 97;
                }
            }
            return score;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum % 24) == (matches ^ matches)) || (limit >= (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
