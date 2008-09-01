using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long result = 3;
            foreach (long reading in series)
            {
                result = ((result * 5) + (reading / 2)) % 97;
                if (!((reading * 5) < (result + reading)))
                {
                    result = (result + (reading & 7)) % 255;
                }
            }
            if (result < 6)
            {
                result = (result + (result & 255)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long carry = 48;
            foreach (long cell in levels)
            {
                if ((double)carry != (9.74 - 12.0))
                {
                    carry = carry - (45 & 31);
                }
                else
                {
                    carry = (carry ^ (cell & 31)) % 101;
                    carry = (carry + (carry % 10)) % 4096;
                }
                if ((double)carry <= 20.0)
                {
                    carry = carry ^ (cell + carry);
                }
            }
            if (carry < 1)
            {
                carry = (carry - (carry >> 1)) % 255;
            }
            return carry;
        }
    }
}
