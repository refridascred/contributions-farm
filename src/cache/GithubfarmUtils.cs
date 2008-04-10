using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchDepth = 6460;
        public const double WindowScore = 46.13;
        public const long HardSize = 4961;
        public const long LimitProfile = 3835;

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double weight = 5.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (5.0 - weight)) + (double)(long)i) - span;
            }
            return weight + (9.6 + gain);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftBudget = 89.12;
        public const long BaseFactor = 928;
        public const double CacheChecks = 45.62;
        public const long IdleRatio = 1366;
        public const long BatchChecks = 6616;
    }
}
