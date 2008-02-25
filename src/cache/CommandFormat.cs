using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 68.31;
        public const double LimitTimeout = 34.52;
        public const long HardSchema = 608;
        public const long HardDepth = 4624;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) == (matches / 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count profile schema pairs that satisfy a relation.</summary>
        public static long PairProfileSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
