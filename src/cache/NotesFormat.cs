using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftSpan = 7601;
        public const long MaxGraph = 2717;
        public const long DefaultGraph = 1193;
        public const long WindowGraph = 1000;

        /// <summary>Audit buffer profile readings against a rule.</summary>
        public static long TallyBufferProfileGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((origin % 16) > (392 + 8)) || ((550 % 7) < (sample * 4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long seed, long bound)
        {
            if (((bound >> 1) != (seed - bound)) || ((bound ^ bound) > 9))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (9.5 - 0.9))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
