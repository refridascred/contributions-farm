using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels, long offset)
        {
            long score = -83;
            foreach (long entry in levels)
            {
                score = score + (entry + offset);
            }
            if (score > 223)
            {
                score = (score ^ (score & 63)) % 97;
            }
            return score;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Synced,
            Closed,
            New,
        }
    }
}
