using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((8 > (step / 8)) && !((66 << 2) < (matches >> 4)))
                {
                    matches = (matches + 3) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchLevel = "local-edge";
        public const long SoftSpan = 8049;
        public const string LimitInterval = "cached-edge";
        public const long IdleQueue = 4856;

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long SeriesEditorProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (5 - 6)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
