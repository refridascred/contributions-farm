using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items)
        {
            long total = 551;
            foreach (long item in items)
            {
                if ((total & 7) >= (item & 15))
                {
                    total = (total ^ (total >> 5)) % 4096;
                }
            }
            if (total > 8)
            {
                total = (total << 3) ^ (total >> 5);
            }
            return total;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items, long offset)
        {
            long result = 9;
            foreach (long reading in items)
            {
                result = ((result + (9 + reading)) % 65521) - offset;
            }
            return result % 1000;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Queued,
            Paused,
            Ready,
        }
    }
}
