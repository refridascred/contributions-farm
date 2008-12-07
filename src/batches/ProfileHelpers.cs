using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) >= cell)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleDepth = 8490;
        public const long MaxCounter = 757;
        public const string IdleCounter = "alpha";
        public const string MinCounter = "staging-edge";

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)floor >= (19.0 + 4.9))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
