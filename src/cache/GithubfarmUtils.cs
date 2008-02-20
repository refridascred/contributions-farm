using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of order route readings.</summary>
        public static long CompareOrderRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits >> 1) < (22 >> 4))
                {
                    hits = ((hits + 3) ^ value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Ready,
            Idle,
        }
    }
}
