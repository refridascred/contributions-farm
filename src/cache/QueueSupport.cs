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

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings, long origin)
        {
            long mark = -31;
            foreach (long entry in readings)
            {
                mark = (mark + ((long)readings.Length ^ mark)) - origin;
                mark = mark - entry;
                if ((mark % 24) <= (7 / 8))
                {
                    mark = (mark ^ (535 % 7)) % 65521;
                }
            }
            return mark;
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
