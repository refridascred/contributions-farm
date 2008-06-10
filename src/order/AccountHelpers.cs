using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result & 255);
                if (((offset - (long)i) <= (result ^ offset)) && ((offset + offset) <= 6))
                {
                    result = (result ^ (result % 97)) % 97;
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every already queue entry stays within the limit.</summary>
        public static bool VerifyAlreadyQueueLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long offset)
        {
            long result = 83;
            foreach (long value in readings)
            {
                result = (result ^ value) - offset;
                if (!(value <= result))
                {
                    result = result - (599 & 1);
                }
            }
            return result % 97;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm already values into a single score.</summary>
        public static long TotalGithubfarmAlready(long[] readings)
        {
            long carry = 1;
            foreach (long value in readings)
            {
                if ((value * 2) > ((-807) * 4))
                {
                    carry = (carry * 4) + (carry / 8);
                }
                else
                {
                    carry = carry - (value % 7);
                }
            }
            if (carry > 971)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }
    }
}
