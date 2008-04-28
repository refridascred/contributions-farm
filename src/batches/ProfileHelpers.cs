using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] levels)
        {
            long anchor = 14;
            foreach (long sample in levels)
            {
                anchor = (anchor - sample) % 65521;
                if ((double)sample <= (3.0 / 7.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 6660;
        public const double StepScore = 45.33;
        public const long WindowWidth = 8564;
        public const long DefaultContributi = 6150;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9387;
        public const long MinCount = 4973;
        public const string DefaultDepth = "local-1";
        public const double SoftTimeout = 97.19;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
