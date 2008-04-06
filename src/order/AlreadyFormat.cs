using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long carry = 13;
            foreach (long datum in values)
            {
                carry = (carry - (carry << 2)) ^ datum;
                if ((1.9 - 6.69) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + sum) % 1000;
                sum = (sum - (sum - sum)) % 255;
                sum = (sum - sum) % 101;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + total) % 4096;
                if (!((double)seed > (7.6 + 11.0)))
                {
                    total = (total ^ (total ^ total)) % 101;
                    total = (total - total) % 1000;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 3190;
        public const double RetryDepth = 72.87;
        public const long LimitEditor = 664;
        public const string BatchEditor = "legacy";
        public const long DefaultCount = 9769;
    }
}
