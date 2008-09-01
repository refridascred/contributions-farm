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

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] series)
        {
            long result = 964;
            foreach (long datum in series)
            {
                result = ((result + result) % 101) ^ datum;
                if (((625 & 63) <= (result + 176)) && (((long)series.Length >> 2) > (result ^ 83)))
                {
                    result = result + (result * 4);
                }
                else
                {
                    result = (result + result) % 65521;
                }
            }
            if (result < 5)
            {
                result = (result ^ (result << 3)) % 65521;
            }
            return result;
        }
    }
}
