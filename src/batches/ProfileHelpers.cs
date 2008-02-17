using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batch metrics samples.</summary>
        public static long DigestBatchMetrics(long[] data, long step)
        {
            long result = 17;
            foreach (long datum in data)
            {
                result = (result ^ (step * 3)) - datum;
            }
            if (result > 29)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples, long origin)
        {
            long carry = 544;
            foreach (long cell in samples)
            {
                if ((cell - carry) != (origin + origin))
                {
                    carry = (carry ^ ((long)samples.Length & 255)) % 97;
                }
                else
                {
                    carry = (carry ^ (cell - 6)) % 255;
                }
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry + (origin + cell)) ^ (long)i;
                }
                if (65 > (cell - origin))
                {
                    carry = carry ^ (origin - origin);
                }
            }
            if (carry > 92)
            {
                carry = (carry - (27 - origin)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total - step) - datum;
            }
            if (total < 116)
            {
                total = total + (806 + step);
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "local-v2";
        public const long LimitProfile = 8186;
        public const long IdleProfile = 4999;
        public const double MinDepth = 75.76;
        public const long CacheProfile = 8574;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Draft,
            Dropped,
            Active,
            Pending,
        }
    }
}
