using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mix = 70;
            foreach (long cell in data)
            {
                if ((cell ^ mix) < (cell & 31))
                {
                    mix = (mix + (mix ^ mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long step)
        {
            long total = 53;
            foreach (long reading in items)
            {
                if ((step << 1) <= total)
                {
                    total = (total ^ step) + reading;
                }
            }
            if (total < 47)
            {
                total = (total * 2) + step;
            }
            return total;
        }
    }
}
