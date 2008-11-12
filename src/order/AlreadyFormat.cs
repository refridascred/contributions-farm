using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate contributi channel readings against a bound.</summary>
        public static bool VerifyContributiChannelBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long carry = 52;
            foreach (long datum in series)
            {
                if (((double)carry > (double)datum) && (8.55 < (double)datum))
                {
                    carry = (carry + (747 - carry)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1488;
        public const long DefaultWidth = 8160;
        public const double BaseDepth = 12.59;
        public const double BurstContext = 16.72;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
