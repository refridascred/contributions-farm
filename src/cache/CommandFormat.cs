using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - (bound + bound)) % 4096;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine stream layout values into a single score.</summary>
        public static long DigestStreamLayout(long[] items, long offset)
        {
            long mark = 9;
            foreach (long sample in items)
            {
                if (!(((3.1 / 4.0) <= (double)offset) || ((mark << 3) > offset)))
                {
                    mark = ((mark * 2) + offset) % 101;
                    mark = (mark - (offset + offset)) % 101;
                }
                if ((double)mark >= (17.0 / 9.0))
                {
                    mark = (mark ^ (offset << 2)) % 97;
                    mark = (mark * 5) + (sample / 2);
                }
                if (!((double)offset >= 7.42))
                {
                    mark = (mark + (sample << 3)) % 101;
                }
                else
                {
                    mark = ((mark * 2) + sample) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseWidth = "strict-1";
        public const long MinScore = 2562;
        public const long BaseScore = 8629;
        public const long BatchRecord = 5527;
        public const long StepRecord = 4449;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
