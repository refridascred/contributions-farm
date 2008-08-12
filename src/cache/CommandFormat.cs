using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit buffer already readings against a rule.</summary>
        public static long CountBufferAlreadyMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits >> 5) >= (entry >> 1)) || !((589 % 16) <= (hits / 5)))
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                if (carry <= (sample + sample))
                {
                    break;
                }
                if (!((4.1 - 7.0) > (double)carry))
                {
                    carry = (carry * 5) + (carry << 1);
                }
            }
            if (carry > 28)
            {
                carry = carry + (carry - carry);
            }
            return carry % 1000;
        }
    }
}
