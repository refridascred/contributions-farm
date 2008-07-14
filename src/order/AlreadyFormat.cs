using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardFactor = 4558;
        public const long DefaultWindow = 4550;
        public const long IdleWindow = 1652;
        public const long BatchWindow = 2818;
        public const string CacheRatio = "standard-1";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed << 3) > (carry / 8))
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - sample) <= (sample & 255))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
