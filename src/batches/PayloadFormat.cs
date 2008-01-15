using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((double)carry >= (double)9) || ((double)carry >= (3.46 * 0.2)))
                {
                    carry = (carry * 2) + (long)i;
                }
                else
                {
                    carry = (carry - limit) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches >= (value % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
