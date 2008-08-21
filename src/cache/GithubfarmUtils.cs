using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Done,
            New,
            Locked,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(((double)hits <= 8.7) || ((double)hits <= 10.0)))
                {
                    hits = ((hits + 3) ^ value) - floor;
                }
            }
            return hits;
        }
    }
}
