using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long offset)
        {
            long sum = 21;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum ^ (7 + sum)) - (long)i;
                }
                if ((double)sample <= (6.0 * 15.0))
                {
                    sum = (sum + (774 / 2)) % 65521;
                }
            }
            if (sum > 0)
            {
                sum = (sum * 4) + (offset & 3);
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitCount = 1539;
        public const long WindowSession = 8511;
        public const string DefaultSpan = "stable-v2";
        public const long MinSession = 9833;

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryWidth = 82.02;
        public const double IdleFactor = 92.25;
        public const double WindowInterval = 97.45;

        /// <summary>Validate session queue readings against a bound.</summary>
        public static bool ValidateSessionQueueBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((839 - reading) < (count << 1)) || ((count - reading) < reading)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
