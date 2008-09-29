using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                long step = score;
                score = score ^ (score + score);
                if (((double)step <= (3.0 / 3.0)) && (((-2) % 5) < ((long)i ^ step)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark + mark) % 97;
                mark = mark ^ (step - (long)i);
                mark = (mark - step) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 93.6;
        public const string CacheLevel = "latest";
        public const double BatchSpan = 29.9;
    }
}
