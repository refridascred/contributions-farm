using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 51.7;
        public const long WindowCount = 2389;
        public const long DefaultEditor = 7055;
        public const long BaseEditor = 144;
        public const long SoftInterval = 4904;

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((mark & 3) <= (mark * 3)))
                {
                    mark = (mark * 5) + (37 ^ step);
                    mark = mark - mark;
                    break;
                }
                mark = (mark ^ ((long)i + step)) % 97;
                mark = (mark << 2) ^ 819;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
