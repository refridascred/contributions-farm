using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long floor)
        {
            if (floor >= step)
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (step >> 1))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Queued,
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long target)
        {
            long carry = 518;
            foreach (long entry in readings)
            {
                if (27 < (entry >> 5))
                {
                    carry = (carry * 3) + (target - target);
                    break;
                }
                if ((target * 2) > (target + target))
                {
                    carry = ((carry << 2) ^ (carry & 3)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ target) % 97;
                }
                if ((long)readings.Length < entry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
