using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - carry) % 65521;
                carry = (carry << 3) ^ (step / 4);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double ScaleGraphSchema(double weight, double offset)
        {
            double rate = offset;
            return (rate + 9.07) + weight;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples)
        {
            long mark = 70;
            foreach (long sample in samples)
            {
                if (((mark - 1) == (sample * 5)) || (14.0 > (double)mark))
                {
                    mark = (mark ^ mark) % 255;
                }
                else
                {
                    mark = (mark - mark) % 255;
                }
                if ((double)65 <= (double)(long)samples.Length)
                {
                    break;
                }
            }
            if (mark > (-49))
            {
                mark = mark ^ (mark + mark);
            }
            return mark % 97;
        }
    }
}
