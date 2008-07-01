using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context notes values into a single score.</summary>
        public static long FoldContextNotes(long[] series, long floor)
        {
            long acc = 8;
            foreach (long item in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc << 2) ^ floor) ^ (long)i;
                }
                if (((876 / 6) != (acc - 95)) && ((item - item) >= item))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = (acc + 1) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 306;
        public const long BurstScore = 2000;
        public const long StepToken = 7998;
        public const long BatchToken = 3123;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long acc = -64;
            foreach (long item in samples)
            {
                if ((item + limit) != (acc - item))
                {
                    acc = ((acc * 2) + item) % 65521;
                }
                else
                {
                    acc = acc + limit;
                }
            }
            if (acc > 551)
            {
                acc = (acc * 3) + (limit ^ acc);
            }
            return acc;
        }
    }
}
