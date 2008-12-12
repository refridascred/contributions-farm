using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every cluster editor entry stays within the limit.</summary>
        public static bool VerifyClusterEditorRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the cluster commits entries that pass the check.</summary>
        public static long MeasureClusterCommitsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits >= (cell >> 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
