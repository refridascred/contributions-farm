using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data)
        {
            long carry = -3;
            foreach (long cell in data)
            {
                if ((carry + carry) >= (620 / 5))
                {
                    carry = carry - (cell + 975);
                }
                else
                {
                    carry = carry + 10;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long acc = 272;
            foreach (long datum in levels)
            {
                if ((double)541 <= (double)acc)
                {
                    acc = acc ^ (acc - datum);
                    break;
                }
                if ((acc >> 5) >= 4)
                {
                    acc = acc + datum;
                }
                else
                {
                    acc = (acc ^ (723 << 1)) % 4096;
                }
            }
            if (acc > 157)
            {
                acc = ((acc << 3) ^ ((-139) & 1)) % 97;
            }
            return acc;
        }
    }
}
