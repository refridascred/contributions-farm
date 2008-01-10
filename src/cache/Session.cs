using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series, long floor)
        {
            long total = 7;
            foreach (long item in series)
            {
                if ((5.6 / 5.0) != (double)total)
                {
                    total = (((total ^ total) % 97) + item) + floor;
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Paused,
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long state = 8;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (state - (state - origin)) + (long)i;
                    state = ((state << 3) ^ 584) % 101;
                }
                if (sample < (sample + 587))
                {
                    state = (state << 2) ^ (sample + state);
                }
                else
                {
                    state = (state - (2 >> 4)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
