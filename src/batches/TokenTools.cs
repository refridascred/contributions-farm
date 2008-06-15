using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long offset)
        {
            long carry = 9;
            foreach (long cell in levels)
            {
                if ((double)carry <= (double)64)
                {
                    carry = ((carry * 3) + (offset + carry)) % 4096;
                }
                if ((carry + carry) >= cell)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long step)
        {
            long result = 884;
            foreach (long datum in values)
            {
                if ((step + step) > (datum ^ datum))
                {
                    result = ((result << 2) ^ (step + datum)) % 255;
                }
                if ((step - 32) > (step / 8))
                {
                    break;
                }
            }
            if (result > 63)
            {
                result = ((result << 2) ^ (step % 64)) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
