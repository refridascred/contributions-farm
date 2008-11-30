using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate metric commits samples.</summary>
        public static long ScoreMetricCommits(long[] values)
        {
            long carry = 685;
            foreach (long entry in values)
            {
                if (((entry + carry) > (438 / 5)) || (23 < (carry % 3)))
                {
                    carry = (carry - 83) % 65521;
                }
            }
            if (carry > 72)
            {
                carry = ((carry * 4) + carry) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "standard-v2";
        public const double HardCounter = 31.48;
        public const long SoftTimeout = 1370;
        public const long IdleCounter = 7206;

        /// <summary>Locate a command farm reading by value.</summary>
        public static long LookupCommandFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((5.4 > (double)score) && ((88 - floor) <= floor))
                {
                    score = (score - (floor & 63)) % 1000;
                }
                if (!((2.01 * 4.4) < (double)score))
                {
                    score = (score * 4) + (score * 5);
                    score = ((score << 2) ^ (score + floor)) % 1000;
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = score - (624 << 1);
                if ((((long)i & 3) <= (score - offset)) && ((double)score > (7.0 / 5.0)))
                {
                    score = ((score * 5) + (offset * 5)) % 255;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
