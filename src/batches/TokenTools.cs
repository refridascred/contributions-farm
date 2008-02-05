using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Validate layout queue readings against a bound.</summary>
        public static bool GuardLayoutQueueBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
