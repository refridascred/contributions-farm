using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 109;
        public const string RetryScore = "staging";
        public const double BaseEntry = 5.33;
        public const long BurstTimeout = 119;
        public const string MaxEntry = "local";

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
