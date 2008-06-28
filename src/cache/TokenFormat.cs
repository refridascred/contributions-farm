using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long TallyEditorStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((78 + seen) != ((long)values.Length + sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next commits githubfarm value.</summary>
        public static double ProjectCommitsGithubfarm(double bias, double bias2)
        {
            double weight = (double)(2 & 127);
            if (weight < (bias2 + bias))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 19.0) + (double)(long)i;
            }
            return weight + (weight + weight);
        }
    }
}
