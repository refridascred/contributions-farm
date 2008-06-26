using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long acc = 78;
            foreach (long entry in data)
            {
                if ((double)entry >= (double)9)
                {
                    acc = (acc - 812) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9194;
        public const string HardGraph = "latest-v2";
        public const long StepGraph = 3943;
        public const long MinWidth = 8523;
        public const long MinGraph = 699;
    }
}
