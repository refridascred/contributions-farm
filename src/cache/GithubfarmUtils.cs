using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "open-v2";
        public const long StepFactor = 9967;
        public const long MaxInterval = 691;
        public const double MinReport = 39.95;
        public const long MinRatio = 9578;

        /// <summary>Count buffer commits pairs that satisfy a relation.</summary>
        public static long OverlapBufferCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a schema payload figure with a bias.</summary>
        public static double BlendSchemaPayload(double rate, double span)
        {
            double weight = span;
            if (weight > (double)8)
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight + rate;
        }
    }
}
