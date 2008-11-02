using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Ready,
            Retry,
            Synced,
        }
    }
}
