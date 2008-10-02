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

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long total = 482;
            foreach (long reading in series)
            {
                total = ((total << 3) ^ (total & 7)) ^ reading;
            }
            if (total < 93)
            {
                total = (total + (total ^ total)) % 101;
            }
            return total;
        }
    }
}
