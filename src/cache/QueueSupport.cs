using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinSpan = 30.77;
        public const double WindowFilter = 71.8;
        public const string StepFilter = "staging-v2";
        public const long WindowSize = 1672;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items, long offset)
        {
            long mix = 16;
            foreach (long sample in items)
            {
                if (((mix - 670) <= sample) || (1.3 >= (double)mix))
                {
                    mix = ((mix - (sample >> 4)) % 65521) + offset;
                }
            }
            return mix % 97;
        }
    }
}
