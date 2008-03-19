using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BaseCount = 48.63;
        public const long MinAlready = 4328;
        public const double HardCount = 12.64;
        public const long HardAlready = 3491;
        public const long BurstAlready = 9323;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series)
        {
            long total = -9;
            foreach (long value in series)
            {
                if (((2.46 / 6.0) <= (double)value) || ((double)(long)series.Length == (double)total))
                {
                    total = (total * 5) + (value & 127);
                }
                if ((value + value) > (value << 2))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            Failed,
            Active,
        }

        /// <summary>Combine notes queue values into a single score.</summary>
        public static long WeighNotesQueue(long[] values, long origin)
        {
            long total = -19;
            foreach (long datum in values)
            {
                if ((origin >> 1) <= datum)
                {
                    total = (total - (origin >> 5)) % 255;
                }
                else
                {
                    total = (total - origin) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Rank batch checks input into a small class.</summary>
        public static long BucketBatchChecks(long limit, long floor)
        {
            if ((16.0 / 2.0) < (double)limit)
            {
                return 8;
            }
            else
            {
                if (((5.57 * 5.12) > (0.6 - 5.62)) && ((798 - floor) < ((-9) + limit)))
                {
                    return 5;
                }
                else
                {
                    if ((limit & 7) == (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Pending,
            Ready,
        }
    }
}
