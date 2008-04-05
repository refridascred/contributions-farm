using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long carry = -290;
            foreach (long entry in levels)
            {
                carry = carry ^ (151 & 3);
                if ((carry % 64) > ((-61) + 0))
                {
                    carry = carry ^ (carry ^ carry);
                    continue;
                }
                if (entry <= (16 / 2))
                {
                    carry = (carry + carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "standard";
        public const string HardFactor = "open-1";
        public const double BurstAccount = 29.69;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
