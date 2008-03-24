using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if (target > (target >> 1))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }
    }
}
