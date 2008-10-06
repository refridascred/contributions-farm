using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 15) > seen)
                {
                    seen = ((seen + 2) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long StepCommandFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry * 4) + (carry & 7)) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of command queue readings.</summary>
        public static long ScoreCommandQueue(long[] series, long origin)
        {
            long score = 41;
            foreach (long reading in series)
            {
                if (!((7 * 5) > (reading >> 4)))
                {
                    score = (score + 88) + origin;
                }
            }
            if (score < 783)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score % 1000;
        }
    }
}
