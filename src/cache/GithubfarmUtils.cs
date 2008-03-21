using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (32 < count)
                {
                    count = ((count + 2) + datum) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long origin)
        {
            long cur = bound + origin;
            if ((origin + bound) == (cur * 5))
            {
                return 6;
            }
            else
            {
                if (((origin << 3) >= (bound + origin)) || ((bound ^ bound) < (origin % 16)))
                {
                    return 1;
                }
                else
                {
                    if ((8.1 + 13.0) >= (double)cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.6 * 8.81) <= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double offset)
        {
            double bias2 = 8.0;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (bias2 / 7.0)) + (double)(long)i) - offset;
            }
            return bias2 - (bias / 4.0);
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
