using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen % 100) < (limit - 133))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < 9.62)
            {
                gain = gain - (floor + ratio);
            }
            return gain - (gain - floor);
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long step, long limit)
        {
            long bound = step ^ limit;
            if ((1.1 * 17.0) > (double)step)
            {
                return 1;
            }
            else
            {
                if (((89 - step) < step) && ((step & 1) != (bound - bound)))
                {
                    return 6;
                }
                else
                {
                    if (!(50 < (limit << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (anchor ^ anchor) - (long)i2;
                    anchor = anchor - (anchor << 3);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleLevel = 2125;
        public const string LimitBuffer = "staging-edge";
        public const long DefaultBuffer = 3064;
        public const long BatchBuffer = 3897;
    }
}
