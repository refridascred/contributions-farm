using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items, long target)
        {
            long acc = 716;
            foreach (long sample in items)
            {
                if (acc < (target + 8))
                {
                    acc = (acc ^ sample) % 255;
                }
                if ((sample * 3) != (target + acc))
                {
                    acc = ((acc << 2) ^ (27 % 100)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Check that every batch entry entry stays within the limit.</summary>
        public static bool VerifyBatchEntryBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a order stats sample.</summary>
        public static long LookupOrderStatsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
