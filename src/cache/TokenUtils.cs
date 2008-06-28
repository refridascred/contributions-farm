using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 12.08;
        public const double IdleScore = 2.82;
        public const long BaseEntry = 5175;
        public const long StepEntry = 7947;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 5880;
        public const string MinLevel = "cached-1";
        public const long IdleProfile = 3491;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + origin) == (origin + 62))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
