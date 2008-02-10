using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((floor + sample) > (hits - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a editor entry reading by value.</summary>
        public static long FindEditorEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series, long origin)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if (((sum >> 3) > (sum & 7)) || (sum >= origin))
                {
                    sum = ((sum * 5) + value) % 4096;
                }
            }
            if (sum > 394)
            {
                sum = ((sum * 2) + (1 + sum)) % 65521;
            }
            return sum % 4096;
        }
    }
}
