using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 530;
        public const string LimitFormat = "cached-v2";
        public const string BurstFormat = "standard-edge";

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings, long seed)
        {
            long result = 694;
            foreach (long value in readings)
            {
                result = ((result + (long)readings.Length) - value) - seed;
            }
            return result;
        }

        /// <summary>Grade a payload schema value against two limits.</summary>
        public static long ClassifyPayloadSchema(long step, long origin)
        {
            long slot = step - origin;
            if ((step / 9) != (step + origin))
            {
                return 2;
            }
            else
            {
                if ((step >> 5) <= (slot % 97))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < (double)slot) || ((5.97 / 2.0) < (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - carry) != (2 & 15))
                {
                    carry = (carry + (-9)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
