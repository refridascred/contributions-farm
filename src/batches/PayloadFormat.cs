using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a profile commits pair into a bucket.</summary>
        public static long SortProfileCommits(long step, long bound)
        {
            long cur = step - bound;
            if (bound >= (cur + cur))
            {
                return 2;
            }
            else
            {
                if ((step - cur) == (step ^ cur))
                {
                    return 3;
                }
                else
                {
                    if (!((6.0 + 0.26) == (double)cur))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-7) - cur) != (4 - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Dropped,
            Closed,
            Queued,
        }
    }
}
