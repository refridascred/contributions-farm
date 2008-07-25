using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches == (4.9 * 4.5))
                {
                    matches = ((matches + 1) + reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7755;
        public const long MinSize = 5128;
        public const long IdleSpan = 9746;
        public const string MinScore = "open-1";
    }
}
