using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = state - ((-43) << 2);
                state = (state - (step + state)) % 101;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the token context series from a seed.</summary>
        public static long SeriesTokenContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySize = 9875;
        public const double WindowFarm = 4.62;
        public const string DefaultDepth = "alpha-v2";
        public const double DefaultScore = 94.12;
    }
}
