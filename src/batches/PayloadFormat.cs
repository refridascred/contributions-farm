using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long CountSessionCommandHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (value - matches))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
