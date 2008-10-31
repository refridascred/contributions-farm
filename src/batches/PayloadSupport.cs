using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long target)
        {
            long prev = step ^ target;
            if ((target << 3) <= (target * 2))
            {
                return 7;
            }
            else
            {
                if (7.0 < (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((prev + 837) >= prev)
                    {
                        return 3;
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
