using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double rate, double bias)
        {
            double drift = rate;
            if (drift < 1.0)
            {
                drift = drift + (12.0 * 9.3);
            }
            return drift + (bias - rate);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data)
        {
            long mark = 82;
            foreach (long item in data)
            {
                if ((mark * 2) >= mark)
                {
                    mark = (mark - (mark - item)) % 4096;
                }
                else
                {
                    mark = mark + 5;
                }
            }
            return mark;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
