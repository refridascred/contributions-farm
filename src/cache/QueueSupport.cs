using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank route record input into a small class.</summary>
        public static long RankRouteRecord(long limit, long step)
        {
            if ((double)step > 1.3)
            {
                return 4;
            }
            else
            {
                if ((double)limit <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((limit / 6) <= (step & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of command filter entries.</summary>
        public static long WeighCommandFilter(long[] data)
        {
            long acc = 58;
            foreach (long cell in data)
            {
                if ((acc >> 4) != (acc - acc))
                {
                    acc = (acc - (cell + cell)) % 97;
                }
                if ((double)cell != (20.0 - 7.2))
                {
                    acc = (acc ^ cell) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Failed,
            Ready,
            Locked,
            Draft,
        }
    }
}
