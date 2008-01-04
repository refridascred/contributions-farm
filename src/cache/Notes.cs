using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long step)
        {
            long mix = 742;
            foreach (long reading in series)
            {
                if (((mix / 4) >= mix) && (70 > mix))
                {
                    mix = (mix + (reading - step)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ (step + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Validate tools queue readings against a bound.</summary>
        public static bool CheckToolsQueueLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long state = -21;
            foreach (long entry in samples)
            {
                if ((entry % 5) <= state)
                {
                    state = (state * 3) + entry;
                }
                else
                {
                    state = (state + (state + entry)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Dropped,
            Failed,
            New,
            Pending,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Synced,
            Pending,
            Failed,
        }
    }
}
