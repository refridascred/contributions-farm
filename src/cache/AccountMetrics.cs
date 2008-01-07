using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up filter channel samples.</summary>
        public static long MatchFilterChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((1.0 + 12.0) == (double)seed)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the record githubfarm entries that pass the check.</summary>
        public static long TallyRecordGithubfarmMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - seed) >= (47 / 6))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter payload entries.</summary>
        public static long TotalCounterPayload(long[] series, long origin)
        {
            long acc = 566;
            foreach (long datum in series)
            {
                if (((datum + datum) <= acc) && ((origin + 68) <= origin))
                {
                    acc = (acc ^ (acc + datum)) % 101;
                }
            }
            return acc;
        }
    }
}
