using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batch graph samples are out of range.</summary>
        public static long TallyBatchGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + item) == (745 ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long anchor = 152;
            foreach (long reading in values)
            {
                anchor = (anchor << 2) ^ anchor;
                if ((anchor ^ 2) == (7 - reading))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
