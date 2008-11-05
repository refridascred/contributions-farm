using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Derive the next format graph value from a seed.</summary>
        public static long StepFormatGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Paused,
            Failed,
            Queued,
        }
    }
}
