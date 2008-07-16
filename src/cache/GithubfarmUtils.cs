using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = acc ^ limit;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items, long step)
        {
            long acc = 0;
            foreach (long value in items)
            {
                acc = (((acc * 5) + (88 + step)) % 4096) + value;
            }
            if (acc < 62)
            {
                acc = acc - (acc + step);
            }
            return acc;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
