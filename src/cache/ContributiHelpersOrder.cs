using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample >= ((long)values.Length + offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
