using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 3166;
        public const long MaxScore = 4089;
        public const double RetrySize = 23.2;
        public const string CacheBatch = "cached";

        /// <summary>Fold a list of editor channel readings.</summary>
        public static long WeighEditorChannel(long[] values)
        {
            long total = 8;
            foreach (long reading in values)
            {
                total = (total ^ reading) % 97;
            }
            return total;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset + 252) < (offset + offset))
                {
                    sum = ((sum << 2) ^ (sum & 7)) % 101;
                }
                sum = sum ^ 861;
                if (!(((long)i % 10) <= (offset + (long)i)))
                {
                    sum = (sum * 5) + (sum ^ sum);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Locked,
            Stale,
            Active,
        }
    }
}
