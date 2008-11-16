using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Count commits account pairs that satisfy a relation.</summary>
        public static long PairCommitsAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
