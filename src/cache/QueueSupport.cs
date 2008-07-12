using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long total = 731;
            foreach (long entry in samples)
            {
                total = (total * 5) + entry;
            }
            if (total > 0)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Retry,
            Active,
            Done,
            Locked,
        }
    }
}
