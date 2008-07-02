using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long bound)
        {
            long lane = step - bound;
            if ((80 - (-6)) <= lane)
            {
                return 6;
            }
            else
            {
                if (lane < (9 ^ 50))
                {
                    return 1;
                }
                else
                {
                    if ((lane >> 2) >= (1 + lane))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((730 << 1) <= (lane + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 3225;
        public const double WindowChecks = 68.39;
        public const long MinScore = 1170;
        public const long IdleChecks = 2096;
        public const string RetryWidth = "legacy-1";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many record tools samples are out of range.</summary>
        public static long CountRecordToolsGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((cell % 97) <= (cell % 2)) && (matches < (matches ^ (long)data.Length)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
