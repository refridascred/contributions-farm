using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 7257;
        public const long SoftProfile = 5185;
        public const string BurstProfile = "open-1";

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double bias, double offset)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = (scale + bias) - offset;
            }
            return scale + bias;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long acc = 6;
            foreach (long sample in data)
            {
                acc = ((acc + (8 ^ 348)) % 255) + sample;
                acc = (acc << 2) ^ (76 >> 4);
            }
            if (acc > 546)
            {
                acc = (acc - (acc << 1)) % 97;
            }
            return acc;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
