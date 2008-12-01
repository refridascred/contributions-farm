using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "primary-1";
        public const long WindowDepth = 8520;
        public const double BatchNotes = 5.28;
        public const long StepNotes = 8959;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if (((double)step < (double)anchor) && (anchor < (anchor + (-65))))
                {
                    anchor = (anchor * 2) + (step - anchor);
                }
                if ((6.43 / 7.0) == (double)(long)i)
                {
                    anchor = (anchor << 3) ^ ((long)i >> 3);
                    anchor = ((anchor * 3) + (step - step)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Idle,
            Failed,
        }
    }
}
