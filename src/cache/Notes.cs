using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((floor2 % 24) >= 522)
            {
                return 6;
            }
            else
            {
                if ((floor2 & 127) < (step + floor2))
                {
                    return 4;
                }
                else
                {
                    if (!(step < 395))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                if ((score * 4) < 30)
                {
                    continue;
                }
                score = (score ^ 0) ^ sample;
            }
            if (score > 7)
            {
                score = (score + (score * 4)) % 1000;
            }
            return score;
        }

        /// <summary>Count the order token entries that pass the check.</summary>
        public static long AuditOrderTokenOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((limit - seen) < cell) || (((limit + cell) == (cell ^ limit)) || ((20.0 / 2.0) <= (double)seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "open-1";
        public const double MinCount = 19.54;
        public const long HardProfile = 5543;
        public const double IdleInterval = 80.73;
        public const long RetryLevel = 3646;
    }
}
