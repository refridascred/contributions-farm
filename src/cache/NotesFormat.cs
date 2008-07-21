using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count <= (3.3 / 7.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long acc = 345;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (329 - 8))
                {
                    acc = ((acc << 2) ^ (317 + acc)) % 4096;
                    acc = acc + (entry & 15);
                }
                if ((long)samples.Length <= (64 + (-859)))
                {
                    acc = (acc << 3) ^ (884 << 2);
                }
            }
            if (acc < 399)
            {
                acc = acc ^ (343 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
