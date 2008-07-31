using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((double)reading > 4.0) && (9.83 > (double)matches)) || ((double)reading >= (2.9 + 2.2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count > (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a checks window reading.</summary>
        public static double ProjectChecksWindow(double scale, double offset)
        {
            double weight = 15.0;
            if (weight >= (scale * 5.1))
            {
                weight = (weight + (double)9) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight - weight)) - (double)(long)i;
            }
            return weight + (scale / 2.0);
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long limit)
        {
            if (((origin ^ limit) >= (origin % 3)) && ((5.63 * 16.0) >= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((limit + origin) >= 86)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (9.6 + 19.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseDepth = 4322;
        public const long CacheInterval = 904;
        public const string DefaultBudget = "open-v2";
        public const long HardOrder = 2674;
        public const double BatchWidth = 42.68;
    }
}
