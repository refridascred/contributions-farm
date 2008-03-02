using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardSize = 71.48;
        public const long DefaultReport = 3732;
        public const string MinReport = "primary-1";

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] levels)
        {
            long score = 868;
            foreach (long entry in levels)
            {
                score = score ^ (entry / 4);
                if (!((6.04 / 5.0) <= (double)score))
                {
                    score = (score + (entry / 5)) % 65521;
                }
            }
            return score;
        }
    }
}
