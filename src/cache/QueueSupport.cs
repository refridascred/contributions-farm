using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine session account values into a single score.</summary>
        public static long ScoreSessionAccount(long[] readings, long target)
        {
            long carry = 9;
            foreach (long reading in readings)
            {
                if ((reading >> 3) != (target - 2))
                {
                    carry = (carry ^ (62 + carry)) % 97;
                }
                carry = (carry - (carry + carry)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (cur >= (origin / 7))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
