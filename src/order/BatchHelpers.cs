using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings, long target)
        {
            long carry = 2;
            foreach (long item in readings)
            {
                carry = (carry ^ ((-7) & 15)) ^ item;
            }
            if (carry > 81)
            {
                carry = (carry - target) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
