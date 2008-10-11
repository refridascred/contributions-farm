using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ result;
                result = (result ^ result) % 97;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i != ((long)i ^ limit))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate context githubfarm samples.</summary>
        public static long FoldContextGithubfarm(long[] data)
        {
            long result = 971;
            foreach (long entry in data)
            {
                if ((170 - entry) > entry)
                {
                    result = ((result * 5) + (0 << 1)) % 255;
                }
            }
            return result % 65521;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double rate = (ratio - span) / 4.0;
            if (rate <= (ratio * 7.7))
            {
                rate = rate - (1.32 * 6.7);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 7215;
        public const long DefaultLevel = 4203;
        public const string MaxTools = "primary-1";
        public const string BatchTimeout = "legacy-1";
        public const long BurstTools = 9134;
    }
}
