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

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Locked,
            New,
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

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCount = 1755;
        public const double BaseCommand = 80.76;
        public const string StepCount = "open-edge";
    }
}
