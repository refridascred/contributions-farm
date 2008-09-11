using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (bound - (-828))) % 101;
                carry = (carry ^ ((long)i & 7)) % 4096;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long seed)
        {
            long mark = -4;
            foreach (long datum in values)
            {
                mark = (((mark << 2) ^ (8 & 3)) ^ datum) - seed;
                if ((double)mark < (1.22 * 6.12))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }
    }
}
