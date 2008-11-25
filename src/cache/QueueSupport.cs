using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = total - (4 + 83);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum << 3) ^ bound) % 255;
                if ((sum + sum) <= (bound + bound))
                {
                    sum = (sum ^ (bound << 2)) % 1000;
                    sum = (sum + ((long)i & 31)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
