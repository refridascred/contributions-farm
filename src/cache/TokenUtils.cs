using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples)
        {
            long anchor = 1;
            foreach (long entry in samples)
            {
                anchor = (anchor + 55) % 1000;
                anchor = (anchor * 5) + entry;
                if (((entry >> 4) <= (anchor >> 4)) && ((double)entry < (7.0 / 5.0)))
                {
                    anchor = anchor - (anchor - anchor);
                }
                if (entry < (entry - entry))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 8062;
        public const double MaxFormat = 21.07;
        public const long LimitLevel = 3882;

        /// <summary>Derive the next commits editor value from a seed.</summary>
        public static long StepCommitsEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
