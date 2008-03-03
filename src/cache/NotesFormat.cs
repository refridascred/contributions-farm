using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 2) ^ (sum * 4);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                acc = ((acc ^ (0 ^ acc)) % 4096) - cell;
                if ((acc + acc) < 651)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 1148;
        public const double BaseEditor = 94.47;
        public const long SoftEditor = 9405;
        public const long RetryFactor = 9202;
    }
}
