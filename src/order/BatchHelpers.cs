using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of editor contributi readings.</summary>
        public static long CombineEditorContributi(long[] values)
        {
            long carry = -7;
            foreach (long cell in values)
            {
                if (carry <= (carry - cell))
                {
                    carry = carry + (cell % 60);
                }
                carry = (carry + ((-251) - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long mark = 723;
            foreach (long cell in samples)
            {
                if (((cell % 97) >= cell) && ((mark * 4) > (mark ^ mark)))
                {
                    mark = (mark + cell) % 97;
                }
                else
                {
                    mark = (mark + mark) % 4096;
                }
                if ((double)(long)samples.Length == (double)mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
