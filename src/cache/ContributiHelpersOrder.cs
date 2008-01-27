using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Derive the next order contributi value from a seed.</summary>
        public static long SeriesOrderContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = mix ^ offset;
                mix = ((mix << 3) ^ (offset >> 1)) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) > (0 / 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
