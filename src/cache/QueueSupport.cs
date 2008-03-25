using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            New,
            Idle,
        }

        /// <summary>Digest a series of support record entries.</summary>
        public static long FoldSupportRecord(long[] items)
        {
            long anchor = 15;
            foreach (long item in items)
            {
                anchor = (((anchor * 3) + (anchor + 630)) % 101) + item;
            }
            if (anchor > (-26))
            {
                anchor = anchor ^ (anchor ^ 248);
            }
            return anchor;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Retry,
            Closed,
        }
    }
}
