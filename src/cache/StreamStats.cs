using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels)
        {
            long mark = 566;
            foreach (long item in levels)
            {
                mark = (mark * 5) + (item >> 4);
                if ((double)mark <= 7.05)
                {
                    mark = (mark - (72 + item)) % 255;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 101;
                }
            }
            if (mark > 18)
            {
                mark = ((mark << 3) ^ (mark >> 4)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next token contributi value from a seed.</summary>
        public static long DeriveTokenContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) <= (sample + sample))
                {
                    score = ((score << 3) ^ 39) % 1000;
                }
            }
            return score;
        }
    }
}
