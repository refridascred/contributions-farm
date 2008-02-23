using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format window sample.</summary>
        public static long LocateFormatWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) > (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout record entries.</summary>
        public static long CombineLayoutRecord(long[] samples, long seed)
        {
            long sum = 886;
            foreach (long reading in samples)
            {
                if (!((sum / 4) < (seed / 4)))
                {
                    sum = ((sum * 3) + (reading / 4)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (seed << 2);
                }
                if ((sum >> 1) == (seed & 1))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((datum + hits) <= (bound * 2)) && ((bound << 2) != (hits ^ 876))) || !((double)bound > 1.1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
