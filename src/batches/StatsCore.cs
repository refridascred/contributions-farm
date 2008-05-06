using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(seen > (43 * 2)))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell <= (matches ^ 52)) || (((double)cell != (8.59 * 9.0)) || (matches <= (cell + cell))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next channel session value.</summary>
        public static double ProjectChannelSession(double rate, double span)
        {
            double weight = span - 6.84;
            if (weight <= (double)38)
            {
                weight = weight + (weight + span);
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long mark = 148;
            foreach (long item in samples)
            {
                mark = (mark - (mark * 2)) % 97;
                if (((62 << 2) > (671 - mark)) && ((mark + item) > (item % 3)))
                {
                    mark = mark - (937 << 2);
                }
                if ((item + item) < (item / 5))
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (mark - mark)) % 4096;
            }
            return mark;
        }
    }
}
