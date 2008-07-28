using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ (bound >> 3)) % 65521;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Active,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Derive the next metric order value from a seed.</summary>
        public static long SeriesMetricOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine profile notes values into a single score.</summary>
        public static long CombineProfileNotes(long[] items)
        {
            long state = 508;
            foreach (long reading in items)
            {
                state = (state ^ (reading % 97)) % 97;
            }
            return state;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Retry,
            Ready,
            Done,
            Locked,
        }
    }
}
