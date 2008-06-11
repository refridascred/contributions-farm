using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long offset)
        {
            long score = -97;
            foreach (long sample in values)
            {
                if ((6.0 - 1.7) != (double)sample)
                {
                    score = (score - (sample & 63)) % 65521;
                }
            }
            if (score < 7)
            {
                score = (score * 4) + (offset ^ offset);
            }
            return score % 65521;
        }

        /// <summary>Check that every metric graph entry stays within the limit.</summary>
        public static bool GuardMetricGraphBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next queue filter value from a seed.</summary>
        public static long RollQueueFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
