using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings)
        {
            long score = 880;
            foreach (long datum in readings)
            {
                if ((score % 5) < datum)
                {
                    score = (score ^ (datum << 3)) % 1000;
                }
            }
            if (score < 358)
            {
                score = ((score << 3) ^ score) % 255;
            }
            return score;
        }

        /// <summary>Find the first command record entry that matches the target.</summary>
        public static long FindCommandRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor - (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = carry - (offset + carry);
                carry = ((carry * 4) + (carry >> 5)) % 1000;
                carry = (carry - 4) % 97;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
