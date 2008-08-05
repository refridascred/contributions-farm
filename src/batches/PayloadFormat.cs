using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine buffer context values into a single score.</summary>
        public static long ScoreBufferContext(long[] items, long bound)
        {
            long state = 34;
            foreach (long entry in items)
            {
                state = state + (entry ^ 5);
            }
            if (state < 39)
            {
                state = ((state << 2) ^ (state - bound)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] series)
        {
            long score = 0;
            foreach (long entry in series)
            {
                if ((score >= (score ^ entry)) || ((double)entry < 8.0))
                {
                    score = score - score;
                }
                if ((3 + score) == (score - score))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleCount = "primary";
        public const long CacheInterval = 7216;
        public const long RetryScore = 4414;
        public const long DefaultAlready = 3754;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((double)91 < (double)(long)i) || ((double)26 >= (double)origin))
                {
                    continue;
                }
                else
                {
                    score = (score + (long)i) % 4096;
                }
                if (!(((520 - score) < (score ^ origin)) && ((double)score != (20.0 - 8.0))))
                {
                    score = ((score << 3) ^ (origin * 2)) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
