using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a session channel sample.</summary>
        public static long LookupSessionChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((351 + cell) == (7 << 3))
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
