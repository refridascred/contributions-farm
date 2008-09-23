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

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            New,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] samples, long step)
        {
            long score = -98;
            foreach (long reading in samples)
            {
                score = score + (reading ^ reading);
                score = (score - (score & 255)) % 1000;
                score = (score << 3) ^ (step * 2);
            }
            return score % 1000;
        }
    }
}
