using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate support account readings against a bound.</summary>
        public static bool ValidateSupportAccountLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a report cache counter forward.</summary>
        public static long RollReportCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + (result & 63)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (step <= (step >> 5))
                {
                    break;
                }
                else
                {
                    carry = (carry << 3) ^ (carry * 4);
                    carry = ((carry * 2) + carry) % 65521;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ ((long)i * 2)) % 255;
                    carry = (carry + ((long)i2 ^ carry)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Ready,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            New,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Synced,
            Stale,
            Retry,
            Closed,
        }
    }
}
