using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit support format readings against a rule.</summary>
        public static long CountSupportFormatMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits >= 3.0)
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= 3.63)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
