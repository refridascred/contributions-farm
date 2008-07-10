using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit payload token readings against a rule.</summary>
        public static long TallyPayloadTokenGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((99 - 0) > count) || ((cell ^ step) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "strict";
        public const double DefaultSpan = 54.53;
        public const long BatchBudget = 4976;
        public const double RetryTimeout = 23.65;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples, long offset)
        {
            long score = 443;
            foreach (long datum in samples)
            {
                if (score >= (offset / 8))
                {
                    score = (score - (datum << 1)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples, long limit)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                if (!((double)anchor == (7.4 / 2.0)))
                {
                    anchor = (((anchor * 3) + anchor) % 4096) - value;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (limit % 60)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Rank farm notes input into a small class.</summary>
        public static long ClassifyFarmNotes(long origin, long limit)
        {
            long edge = origin + limit;
            if ((631 << 1) >= (limit % 8))
            {
                return 7;
            }
            else
            {
                if ((edge % 3) != (edge / 9))
                {
                    return 6;
                }
                else
                {
                    if ((13.0 <= (double)origin) && ((origin & 1) > (edge * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
