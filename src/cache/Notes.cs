using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample <= (0 - 249))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitScore = 3900;
        public const string LimitRatio = "local-v2";
        public const long BaseFactor = 4986;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
