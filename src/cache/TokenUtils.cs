using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine entry account values into a single score.</summary>
        public static long ScoreEntryAccount(long[] values)
        {
            long total = 4;
            foreach (long reading in values)
            {
                total = total + (reading / 3);
                if ((reading << 3) >= reading)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a farm cache value against two limits.</summary>
        public static long ClassifyFarmCache(long offset, long step)
        {
            if (((double)step > (double)offset) || ((step >> 3) >= (offset >> 5)))
            {
                return 6;
            }
            else
            {
                if (!(step < (offset + step)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Retry,
            Done,
            Dropped,
        }
    }
}
