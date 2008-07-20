using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long mark = 4;
            foreach (long cell in data)
            {
                if (((-26) <= (mark - offset)) || (mark <= (cell % 16)))
                {
                    mark = (mark - (offset + cell)) % 1000;
                }
            }
            if (mark > 95)
            {
                mark = (mark - offset) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Ready,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)seen < (double)468) || !((value - value) <= (step % 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a metric tools reading by value.</summary>
        public static long LocateMetricToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long limit, long origin)
        {
            if ((56 ^ limit) >= (limit % 24))
            {
                return 0;
            }
            else
            {
                if ((limit % 64) > (origin - limit))
                {
                    return 2;
                }
                else
                {
                    if (!(limit >= (849 - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit < (origin ^ 58))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
