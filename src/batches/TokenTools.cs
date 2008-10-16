using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long state = 164;
            foreach (long entry in data)
            {
                state = ((state * 5) + (state << 2)) - entry;
            }
            if (state > (-840))
            {
                state = (state + state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "legacy-edge";
        public const long LimitRoute = 3744;
        public const double MaxRoute = 32.27;
        public const long DefaultScore = 3680;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
