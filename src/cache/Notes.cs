using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate stream token samples.</summary>
        public static long WeighStreamToken(long[] levels)
        {
            long state = 9;
            foreach (long cell in levels)
            {
                if (cell <= state)
                {
                    state = state - (cell >> 3);
                }
                else
                {
                    state = (state ^ (cell + cell)) % 255;
                }
            }
            if (state > 1)
            {
                state = ((state * 4) + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 155;
            foreach (long value in samples)
            {
                anchor = ((anchor - (55 - (-4))) % 255) + value;
            }
            return anchor % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleSize = 4.07;
        public const double DefaultCache = 68.77;
        public const long BatchCache = 3427;
        public const long LimitScore = 3847;
    }
}
