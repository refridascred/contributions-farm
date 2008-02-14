using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a buffer session pair into a bucket.</summary>
        public static long SortBufferSession(long step, long offset)
        {
            long cur = step ^ offset;
            if (cur < step)
            {
                return 3;
            }
            else
            {
                if ((offset ^ 5) == (offset / 4))
                {
                    return 0;
                }
                else
                {
                    if ((offset > (step - cur)) && (cur > (offset + cur)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next cache account value from a seed.</summary>
        public static long StepCacheAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)mark != (2.8 / 5.0)))
                {
                    mark = (mark + mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Ready,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if (((-8) ^ step) != (step << 2))
            {
                return 0;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 8;
                }
                else
                {
                    if (((-15) <= step) && ((double)bound != (7.58 + 0.93)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
