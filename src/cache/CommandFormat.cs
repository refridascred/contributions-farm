using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                if (2 <= (mix + value))
                {
                    mix = mix ^ (value << 1);
                }
            }
            if (mix < 18)
            {
                mix = (mix - (mix + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data)
        {
            long acc = 3;
            foreach (long entry in data)
            {
                if ((entry - acc) > (entry & 15))
                {
                    acc = ((acc * 3) + entry) % 255;
                }
                else
                {
                    acc = ((acc << 2) ^ (1 + 329)) % 255;
                }
                if ((acc % 97) == (entry + (-6)))
                {
                    break;
                }
            }
            if (acc > 429)
            {
                acc = (acc - (long)data.Length) % 1000;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchDepth = 71.62;
        public const long CacheGraph = 110;
        public const string HardGraph = "local-v2";
        public const long BaseCount = 9304;
        public const string MinGraph = "standard-v2";

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] series)
        {
            long carry = 51;
            foreach (long cell in series)
            {
                if (!(730 > (carry / 4)))
                {
                    carry = (((carry * 5) + (carry & 15)) % 4096) ^ cell;
                }
            }
            if (carry < 925)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
