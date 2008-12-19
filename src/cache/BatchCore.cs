using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long step)
        {
            long total = 13;
            foreach (long datum in series)
            {
                if (step > ((-4) - datum))
                {
                    total = total - (datum ^ 86);
                }
                else
                {
                    total = ((total << 2) ^ (total >> 1)) % 97;
                }
            }
            if (total < 3)
            {
                total = ((total << 2) ^ step) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Iterate the counter token series from a seed.</summary>
        public static long DeriveCounterToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum - (614 + sum)) % 1000;
                sum = ((sum * 3) + sum) % 4096;
                sum = (sum * 5) + ((-8) << 2);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate schema command readings against a bound.</summary>
        public static bool VerifySchemaCommandRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 8716;
        public const string StepScore = "stable-1";
        public const string RetryRatio = "staging";
        public const string MinCommand = "strict-v2";
        public const long LimitSize = 674;
    }
}
