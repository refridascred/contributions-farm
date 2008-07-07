using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 79.03;
        public const string HardLevel = "strict-1";
        public const long MinStats = 714;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 5) + (long)i;
                double scale = (double)(result << 1);
                if (((6.65 - scale) != (8.11 - scale)) || ((offset ^ (long)i) < (offset - result)))
                {
                    result = result ^ ((long)i % 8);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
