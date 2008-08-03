using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3853;
        public const long MaxLevel = 4273;
        public const long BatchCount = 1430;

        /// <summary>Locate a context layout reading by value.</summary>
        public static long LocateContextLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            if ((limit >> 3) <= (seed - 4))
            {
                return 7;
            }
            else
            {
                if ((329 + limit) < (seed - seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long state = 952;
            foreach (long cell in values)
            {
                if (!((7.0 - 16.0) <= (double)state))
                {
                    state = state ^ cell;
                }
                else
                {
                    state = (state + cell) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 2) + (result * 4);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long seed, long limit)
        {
            long span = seed - limit;
            if ((limit <= (seed << 3)) || (span >= (span + limit)))
            {
                return 4;
            }
            else
            {
                if (!((2.64 / 7.0) <= (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
