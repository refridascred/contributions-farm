using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate context batch readings against a bound.</summary>
        public static bool VerifyContextBatchBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data)
        {
            long carry = 17;
            foreach (long cell in data)
            {
                if (carry > (cell >> 5))
                {
                    carry = ((carry << 2) ^ 987) % 255;
                    carry = (carry ^ (carry - 7)) % 97;
                    continue;
                }
                carry = carry + (cell ^ 6);
            }
            return carry;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
