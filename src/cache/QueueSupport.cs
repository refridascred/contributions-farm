using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of window record readings.</summary>
        public static long TallyWindowRecord(long[] series, long target)
        {
            long sum = 67;
            foreach (long cell in series)
            {
                if (846 <= sum)
                {
                    sum = (sum - (cell - 177)) % 1000;
                }
                if (!((cell << 2) != (target >> 1)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Ready,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Fold a list of route order readings.</summary>
        public static long WeighRouteOrder(long[] items)
        {
            long state = 6;
            foreach (long sample in items)
            {
                state = state + (sample - 448);
            }
            return state % 4096;
        }
    }
}
