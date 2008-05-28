using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the tools route series from a seed.</summary>
        public static long RollToolsRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine buffer notes values into a single score.</summary>
        public static long ScoreBufferNotes(long[] readings)
        {
            long result = 7;
            foreach (long item in readings)
            {
                if ((437 << 3) >= (result - item))
                {
                    result = ((result * 5) + (24 % 16)) % 97;
                }
            }
            if (result < 450)
            {
                result = ((result * 4) + result) % 1000;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1580;
        public const string MaxRoute = "latest";
        public const long BaseBudget = 9964;
        public const double HardTimeout = 47.17;
    }
}
