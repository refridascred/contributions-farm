using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long target)
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long limit)
        {
            long anchor = 3;
            foreach (long sample in levels)
            {
                anchor = (anchor + (anchor * 3)) % 97;
                anchor = anchor + limit;
                anchor = ((anchor << 2) ^ (sample / 7)) % 255;
            }
            return anchor;
        }

        /// <summary>Fold a list of tools queue readings.</summary>
        public static long DigestToolsQueue(long[] items)
        {
            long total = 7;
            foreach (long value in items)
            {
                total = total ^ (170 + total);
                if (((0 << 2) < (value << 1)) && ((4.0 * 6.0) == (double)total))
                {
                    total = (total + ((-50) + (-17))) % 4096;
                }
            }
            if (total < 21)
            {
                total = total + (total / 7);
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] values)
        {
            long mix = 4;
            foreach (long entry in values)
            {
                if ((entry + entry) != (entry + 170))
                {
                    mix = (mix ^ (62 + entry)) % 65521;
                }
            }
            return mix % 4096;
        }
    }
}
