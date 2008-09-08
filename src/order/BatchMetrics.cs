using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of graph tools readings.</summary>
        public static long ScoreGraphTools(long[] data, long step)
        {
            long result = 75;
            foreach (long datum in data)
            {
                result = (result + datum) % 1000;
                result = ((result * 4) + (result - result)) % 1000;
                if ((9.0 + 6.0) != (double)step)
                {
                    result = (result - (result * 2)) % 255;
                }
                if (!((5.93 * 5.0) < (double)step))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long seed)
        {
            long next = offset - seed;
            if ((double)next <= (6.41 + 4.24))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= 4.1)
                {
                    return 3;
                }
                else
                {
                    if (((-826) / 4) != (next % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)offset != (8.6 + 1.46)) && ((offset % 2) > offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen - seen) == (cell << 2)) && ((double)cell > 14.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 1) > (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Draft,
            Locked,
        }
    }
}
