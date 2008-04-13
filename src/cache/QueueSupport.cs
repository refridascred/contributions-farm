using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 4671;
        public const long BurstTimeout = 8393;
        public const long HardSpan = 987;

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark << 2) ^ (floor << 3);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the contributi batch series from a seed.</summary>
        public static long IterateContributiBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                if (mark <= (bound & 3))
                {
                    mark = (mark << 3) ^ (mark - 0);
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
