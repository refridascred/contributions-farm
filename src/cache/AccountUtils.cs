using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count record channel pairs that satisfy a relation.</summary>
        public static long PairRecordChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record context readings.</summary>
        public static long MatchRecordContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry checks series from a seed.</summary>
        public static long RollEntryChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 3) ^ (total + origin)) % 255;
                if (((long)i + total) >= total)
                {
                    total = (total << 3) ^ origin;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
