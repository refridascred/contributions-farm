using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] items)
        {
            long score = 7;
            foreach (long sample in items)
            {
                score = (score ^ (sample % 5)) % 4096;
                if ((sample + (long)items.Length) <= score)
                {
                    score = (score ^ 7) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "cached-edge";
        public const long WindowRatio = 7260;
        public const string MaxContext = "local";
    }
}
