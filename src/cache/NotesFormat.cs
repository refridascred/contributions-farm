using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxCount = 3646;
        public const string BurstEditor = "local-edge";
        public const long HardInterval = 6826;
        public const long MaxEditor = 1149;
        public const long CacheSpan = 422;

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((4.53 * 0.29) >= 7.6)
                {
                    break;
                }
                long tally = (origin + origin) ^ (origin % 2);
                if ((double)origin > (double)63)
                {
                    anchor = (anchor + tally) % 97;
                    tally = (tally ^ ((long)i % 7)) % 255;
                }
                else
                {
                    tally = (tally * 3) + (21 ^ origin);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count farm order pairs that satisfy a relation.</summary>
        public static long MatchFarmOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
