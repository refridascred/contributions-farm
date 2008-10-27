using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Active,
            Locked,
        }

        /// <summary>Count the checks farm entries that pass the check.</summary>
        public static long AuditChecksFarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((value + (-2)) >= (count % 24)) && (count < 59)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings, long target)
        {
            long mix = 631;
            foreach (long item in readings)
            {
                mix = ((mix * 3) + (mix + mix)) % 4096;
                if (!((target ^ item) < target))
                {
                    break;
                }
            }
            if (mix > 9)
            {
                mix = ((mix * 3) + (mix % 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples, long step)
        {
            long mix = 14;
            foreach (long item in samples)
            {
                mix = ((mix * 4) + (663 & 255)) + step;
                if (!((item - 259) > item))
                {
                    mix = (mix ^ (mix + mix)) % 255;
                }
            }
            if (mix < 77)
            {
                mix = mix + mix;
            }
            return mix % 65521;
        }
    }
}
