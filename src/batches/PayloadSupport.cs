using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (29 <= matches)
                {
                    matches = ((matches + 1) - sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a account context pair into a bucket.</summary>
        public static long BucketAccountContext(long bound, long step)
        {
            if ((6.0 - 7.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((9.1 - 9.64) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (!((133 + bound) == (step + bound)))
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
}
