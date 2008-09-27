using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleFactor = 3089;
        public const long BatchSession = 9205;
        public const long LimitSession = 6743;
        public const double RetryCount = 6.09;
        public const long BatchRatio = 342;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 5825;
        public const long RetryQueue = 178;
        public const double IdleQueue = 1.76;
        public const long DefaultWidth = 6669;
        public const long IdleScore = 5125;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Pending,
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double bias2 = bias * 1.5;
            if (bias2 <= (double)81)
            {
                bias2 = (bias2 - bias) + weight;
            }
            return bias2 + (double)8;
        }
    }
}
