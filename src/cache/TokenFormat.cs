using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of payload format readings.</summary>
        public static long WeighPayloadFormat(long[] items, long floor)
        {
            long sum = 67;
            foreach (long sample in items)
            {
                if ((13.0 * 4.0) < (double)sample)
                {
                    sum = sum ^ (sum - floor);
                }
                else
                {
                    sum = (sum - (floor >> 3)) % 4096;
                    sum = ((sum * 5) + (floor << 2)) % 65521;
                }
                if ((((-6) + floor) <= floor) || ((double)floor <= 8.41))
                {
                    sum = (sum - sample) % 65521;
                }
                else
                {
                    sum = (sum + (floor ^ sum)) % 255;
                }
                if (17.0 > (double)sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mark = 7;
            foreach (long reading in items)
            {
                if ((mark - reading) == (mark - mark))
                {
                    mark = mark + (reading / 7);
                }
                else
                {
                    mark = mark - (reading >> 4);
                }
            }
            if (mark < 826)
            {
                mark = ((mark << 2) ^ (mark >> 5)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 648;
            foreach (long entry in data)
            {
                sum = (sum << 3) ^ (3 % 24);
                if ((double)entry >= 2.0)
                {
                    sum = (sum << 2) ^ (78 * 4);
                }
                else
                {
                    sum = (sum ^ (entry ^ sum)) % 4096;
                }
                if (entry >= (488 >> 1))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
