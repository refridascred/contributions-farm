using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step + step) < mark)
                {
                    mark = (mark - (step >> 5)) % 97;
                    continue;
                }
                if (!((16.0 - 3.49) >= (double)step))
                {
                    mark = (mark - (step % 12)) % 1000;
                }
                mark = (mark ^ (long)i) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "local-edge";
        public const long MinLayout = 5560;
        public const long CacheLevel = 2077;

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
