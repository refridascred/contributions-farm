using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry <= bound) || (entry < (entry << 3))) && ((entry / 9) < entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ target;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleFactor = 6560;
        public const long WindowFactor = 3584;
        public const long BatchGraph = 5619;
        public const double IdleGraph = 0.38;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long bound)
        {
            long offset = floor - bound;
            if (bound <= floor)
            {
                return 0;
            }
            else
            {
                if (((bound % 60) < (bound << 2)) && ((2.0 - 14.0) != (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] series)
        {
            long state = -24;
            foreach (long datum in series)
            {
                state = ((state + state) % 97) + datum;
                state = (state << 3) ^ state;
            }
            return state;
        }
    }
}
