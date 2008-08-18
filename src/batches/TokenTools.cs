using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of format filter readings.</summary>
        public static long MatchFormatFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxLevel = 6219;
        public const double BatchNotes = 12.74;
        public const string BatchRatio = "legacy-edge";

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
