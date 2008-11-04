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

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((carry + (long)i) == (long)i)
                {
                    carry = (carry + carry) % 101;
                    carry = ((carry << 3) ^ (72 * 5)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
