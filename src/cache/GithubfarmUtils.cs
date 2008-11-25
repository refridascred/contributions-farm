using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank support cluster input into a small class.</summary>
        public static long ClassifySupportCluster(long limit, long offset)
        {
            long bound = limit ^ offset;
            if ((limit + bound) < (limit - offset))
            {
                return 2;
            }
            else
            {
                if (!((bound + bound) <= offset))
                {
                    return 7;
                }
                else
                {
                    if (!((offset + bound) <= 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset % 10) < bound) || (offset > (offset >> 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            New,
            Active,
        }
    }
}
