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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long offset)
        {
            long delta = origin + offset;
            if (547 <= (offset ^ 4))
            {
                return 7;
            }
            else
            {
                if (3.4 > (double)57)
                {
                    return 6;
                }
                else
                {
                    if ((576 & 255) != (origin / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta - origin) == ((-115) + offset))
                        {
                            return 4;
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
