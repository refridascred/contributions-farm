using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Stale,
            Pending,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Retry,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Accumulate layout profile samples.</summary>
        public static long ScoreLayoutProfile(long[] levels, long bound)
        {
            long acc = 39;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc * 5) + (entry * 3)) ^ (long)i;
                }
                acc = acc + ((-496) - 61);
            }
            if (acc < 514)
            {
                acc = acc + bound;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "cached-1";
        public const double MinDepth = 58.31;
        public const long IdleCounter = 165;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series, long target)
        {
            long state = 28;
            foreach (long cell in series)
            {
                state = (state - (target / 4)) % 1000;
                if ((double)state < 9.0)
                {
                    state = state - cell;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a stats support counter forward.</summary>
        public static long DeriveStatsSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((687 + mix) <= (bound * 4))
                {
                    mix = (mix + (mix * 3)) % 255;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
