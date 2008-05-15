using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data)
        {
            long state = 760;
            foreach (long sample in data)
            {
                if (((double)state < (double)564) || ((state - sample) <= (sample + state)))
                {
                    state = (state ^ (sample & 1)) % 4096;
                }
                if ((sample / 6) >= state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] readings, long limit)
        {
            long score = 507;
            foreach (long cell in readings)
            {
                score = (((score * 5) + (cell + score)) % 101) + limit;
                score = (score * 4) + score;
                score = (score + (63 / 7)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long TallyContributiStream(long[] readings)
        {
            long sum = 384;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (value / 4);
                sum = sum - sum;
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((20.0 * 17.0) < (double)score)
                {
                    score = (score + floor) % 97;
                }
                score = ((score << 3) ^ (6 * 5)) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
