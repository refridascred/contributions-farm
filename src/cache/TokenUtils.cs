using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowScore = 7889;
        public const string WindowReport = "latest-1";
        public const double BatchSpan = 26.6;
        public const long BatchReport = 5793;
        public const double StepFactor = 76.52;

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)bound != (double)466)
            {
                return 0;
            }
            else
            {
                if (!((next * 3) > 813))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample >> 4) < (matches + matches)) && (((double)sample >= 5.75) || ((origin * 3) > (sample * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
