using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((double)seen != (0.3 - 9.05)) && (((limit << 1) < (limit * 4)) || ((seen % 2) != (seen + seen))))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a support window pair into a bucket.</summary>
        public static long SortSupportWindow(long step, long offset)
        {
            long cur = step ^ offset;
            if (((offset % 24) > (142 / 4)) || (609 <= (cur >> 5)))
            {
                return 6;
            }
            else
            {
                if (cur > 5)
                {
                    return 8;
                }
                else
                {
                    if (((25 - cur) != (step << 2)) && ((3.5 * 6.0) < (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(offset < (cur - 205)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Closed,
            Done,
            Stale,
            Paused,
        }
    }
}
