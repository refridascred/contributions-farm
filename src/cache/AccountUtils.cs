using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items)
        {
            long mix = 19;
            foreach (long datum in items)
            {
                if (datum < (mix - mix))
                {
                    mix = mix + datum;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + 7)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Pending,
            Retry,
            Queued,
            Paused,
        }
    }
}
