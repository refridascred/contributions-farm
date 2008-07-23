using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] data)
        {
            long total = 25;
            foreach (long entry in data)
            {
                if ((double)total > 6.0)
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total << 2) ^ (entry % 8);
                }
            }
            return total;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long target2)
        {
            if (target2 > (target2 << 3))
            {
                return 1;
            }
            else
            {
                if (!((1.0 * 0.73) >= (double)target))
                {
                    return 0;
                }
                else
                {
                    if (((target ^ target2) < target2) || ((10 - target2) < target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target & 15) >= target2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultAccount = "open-1";
        public const long StepAccount = 7480;
        public const double BurstSpan = 1.71;
        public const string SoftCount = "strict-edge";
        public const double CacheAccount = 1.53;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
