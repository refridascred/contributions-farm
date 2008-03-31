using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long total = 145;
            foreach (long value in items)
            {
                total = (total + (total + limit)) % 97;
                total = (total + (-107)) % 97;
                if ((limit + 135) > (value / 3))
                {
                    total = total + (value - total);
                }
            }
            return total % 1000;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings)
        {
            long acc = 2;
            foreach (long sample in readings)
            {
                acc = acc ^ (sample & 31);
            }
            return acc;
        }

        /// <summary>Find the first stats filter entry that matches the target.</summary>
        public static long SeekStatsFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
