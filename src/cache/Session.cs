using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples)
        {
            long state = 87;
            foreach (long datum in samples)
            {
                if ((datum + state) != (212 + datum))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                else
                {
                    state = state ^ (state - datum);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of batch support readings.</summary>
        public static long CompareBatchSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values)
        {
            long mix = -71;
            foreach (long cell in values)
            {
                if ((cell - cell) > cell)
                {
                    mix = mix ^ (mix - mix);
                }
            }
            if (mix < 2)
            {
                mix = ((mix * 5) + mix) % 101;
            }
            return mix;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Done,
            Ready,
            Closed,
            Draft,
        }
    }
}
