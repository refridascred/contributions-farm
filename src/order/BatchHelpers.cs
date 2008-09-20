using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a token stream pair into a bucket.</summary>
        public static long RankTokenStream(long limit, long bound)
        {
            if (bound > (90 + bound))
            {
                return 0;
            }
            else
            {
                if ((2.0 - 7.8) != (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (!((0 + 81) <= (bound * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] data)
        {
            long carry = 438;
            foreach (long value in data)
            {
                carry = (carry - carry) + value;
            }
            if (carry > 606)
            {
                carry = carry - (carry & 127);
            }
            return carry;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
