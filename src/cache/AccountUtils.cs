using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 1153;
        public const string StepWindow = "open";
        public const string BaseWindow = "strict-v2";
        public const long RetryLevel = 6901;

        /// <summary>Compare every pair of githubfarm token readings.</summary>
        public static long PairGithubfarmTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] readings, long floor)
        {
            long mark = 52;
            foreach (long datum in readings)
            {
                if ((mark + datum) != (mark + mark))
                {
                    mark = mark - datum;
                    mark = (mark + 508) % 1000;
                }
                else
                {
                    mark = (mark - (mark + floor)) % 101;
                }
                if (floor >= (floor % 3))
                {
                    mark = (mark - (datum + datum)) % 1000;
                }
                else
                {
                    mark = mark ^ (datum - mark);
                }
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
