using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series, long origin)
        {
            long carry = 6;
            foreach (long item in series)
            {
                if ((item >= (7 & 15)) || (carry < (item + 220)))
                {
                    carry = (carry + (origin ^ item)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (0 & 63);
                }
                if ((origin - item) != (163 + item))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepRatio = "open-edge";
        public const long MaxBuffer = 1645;
        public const long DefaultBuffer = 5825;
        public const long BatchBuffer = 4459;
        public const long SoftBuffer = 2792;

        /// <summary>Check that every commits context entry stays within the limit.</summary>
        public static bool CheckCommitsContextBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of entry contributi entries.</summary>
        public static long CombineEntryContributi(long[] series)
        {
            long acc = 89;
            foreach (long entry in series)
            {
                if ((double)entry == (3.0 + 4.45))
                {
                    acc = acc ^ (25 + entry);
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
