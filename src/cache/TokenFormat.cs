using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor account samples are out of range.</summary>
        public static long AuditEditorAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches & 63) < (item ^ matches)) || !((5.44 * 1.34) >= (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 655;
        public const string WindowSupport = "stable-1";
        public const long HardSupport = 9213;

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long origin, long bound)
        {
            if ((origin / 6) <= (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((double)7 <= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound >= (2.4 * 9.5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound <= (bound - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
