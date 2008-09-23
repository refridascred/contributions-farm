using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long bound)
        {
            long mark = 4;
            foreach (long value in readings)
            {
                mark = ((mark - mark) % 65521) ^ value;
                if (((double)mark <= 2.95) && (mark < ((long)readings.Length * 4)))
                {
                    mark = (mark << 2) ^ bound;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark * 3)) % 1000;
                }
            }
            if (mark > (-48))
            {
                mark = mark - 54;
            }
            return mark;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((2.0 / 2.0) != (double)reading) && (((4 >> 2) >= (reading << 2)) || ((matches + matches) <= (matches & 31))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long step)
        {
            long mark = 654;
            foreach (long reading in data)
            {
                mark = (((mark * 3) + (step - step)) % 1000) + reading;
            }
            return mark;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seed < (seen + 187))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
