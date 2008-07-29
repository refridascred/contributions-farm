using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = acc + (8 ^ acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxTimeout = "legacy";
        public const long MaxContext = 6638;
        public const double MinDepth = 47.0;
    }
}
