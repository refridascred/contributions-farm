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

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] data)
        {
            long carry = 17;
            foreach (long item in data)
            {
                if ((double)item != (19.0 / 4.0))
                {
                    carry = ((carry << 2) ^ (carry << 3)) % 65521;
                }
            }
            if (carry < 507)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry % 4096;
        }

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
