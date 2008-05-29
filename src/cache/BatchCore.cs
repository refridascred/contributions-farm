using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((entry & 31) != (entry - 82)) && (((matches << 1) < (197 + entry)) || ((entry << 2) != (619 - entry))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values, long offset)
        {
            long carry = 364;
            foreach (long datum in values)
            {
                carry = ((carry * 2) + (offset / 9)) ^ datum;
            }
            if (carry < 4)
            {
                carry = (carry - carry) % 255;
            }
            return carry;
        }

        /// <summary>Count batch cluster pairs that satisfy a relation.</summary>
        public static long MatchBatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
