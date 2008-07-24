using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate graph profile samples.</summary>
        public static long DigestGraphProfile(long[] data, long floor)
        {
            long total = 480;
            foreach (long cell in data)
            {
                if (!((double)(long)data.Length >= (double)floor))
                {
                    total = total - (cell + floor);
                }
                total = total + (floor * 2);
            }
            if (total > 7)
            {
                total = total - 76;
            }
            return total;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((seed >> 1) >= (sample & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
