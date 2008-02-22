using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((90 >> 1) == (offset + (long)i)))
                {
                    state = (state + (22 + 802)) % 255;
                }
                else
                {
                    state = (state * 5) + (state ^ (-7));
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state + (offset + state)) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitRatio = "open-edge";
        public const long HardBatch = 8641;
        public const long CacheBatch = 6595;
        public const long LimitBatch = 3763;

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
