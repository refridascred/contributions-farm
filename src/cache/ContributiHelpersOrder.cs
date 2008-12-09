using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepLevel = 5900;
        public const string HardCommits = "local-edge";
        public const long LimitCommits = 4351;
        public const long DefaultFactor = 3295;
        public const string WindowScore = "alpha";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
