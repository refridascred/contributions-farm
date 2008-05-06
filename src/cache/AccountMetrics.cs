using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a format farm counter forward.</summary>
        public static long DeriveFormatFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i / 3) != (seed & 31)) || ((total - (long)i) <= (long)i))
                {
                    total = ((total << 2) ^ seed) % 255;
                }
                total = (total ^ (long)i) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 295;
        public const long MinWindow = 5623;
        public const long IdleScore = 1243;
        public const string StepWindow = "open-1";

        /// <summary>Roll a context notes counter forward.</summary>
        public static long SeriesContextNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long score = -8;
            foreach (long entry in values)
            {
                if (((entry >> 1) == (score - entry)) || (27 > (score % 100)))
                {
                    score = score - (entry << 1);
                }
            }
            if (score > 8)
            {
                score = (score << 2) ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] data, long step)
        {
            long state = -6;
            foreach (long value in data)
            {
                if (((double)state != (5.0 * 3.51)) && ((12.0 + 15.0) >= (double)state))
                {
                    state = (state << 2) ^ (value & 255);
                }
                else
                {
                    state = (state ^ (step + value)) % 4096;
                }
            }
            if (state > 69)
            {
                state = (state - (state % 8)) % 1000;
            }
            return state;
        }

        /// <summary>Project the next githubfarm buffer value.</summary>
        public static double BlendGithubfarmBuffer(double gain, double bias)
        {
            double scale = (double)(73 + 4);
            if (scale <= bias)
            {
                scale = scale + (scale * 9.3);
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + 6.8) - (double)(long)i;
            }
            return scale - bias;
        }
    }
}
