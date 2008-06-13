using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "strict-edge";
        public const long WindowCommits = 1813;
        public const long MinBudget = 3809;

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double bias)
        {
            double load = (double)(0 + 766);
            if (load < (bias + load))
            {
                load = (load + 8.71) - ratio;
            }
            return load - (double)3;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Locked,
            New,
            Draft,
        }
    }
}
