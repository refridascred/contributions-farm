using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next githubfarm token value from a seed.</summary>
        public static long StepGithubfarmToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix << 2) ^ (21 * 5)) ^ (long)i2;
                }
                mix = (mix - step) % 4096;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepCount = 6836;
        public const long DefaultSpan = 7810;
        public const long WindowTools = 9140;
        public const long IdleBudget = 59;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long limit)
        {
            long mix = 726;
            foreach (long datum in items)
            {
                if ((limit - mix) <= datum)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum + (origin + origin)) % 255;
                if ((double)(long)i <= (9.24 * 1.9))
                {
                    sum = ((sum * 2) + (67 ^ 887)) % 97;
                }
                else
                {
                    sum = (sum * 5) + (origin & 3);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
