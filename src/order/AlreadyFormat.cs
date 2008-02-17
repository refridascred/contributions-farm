using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double ratio = (double)(5 ^ 273);
            if (ratio <= (8.4 / 6.0))
            {
                ratio = (ratio - (span * 8.6)) - rate;
            }
            else
            {
                ratio = ratio - (double)84;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (span / 9.0)) + (double)(long)i;
            }
            return ratio - (span + span);
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
