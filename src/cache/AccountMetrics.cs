using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long anchor = 4;
            foreach (long reading in items)
            {
                anchor = ((anchor * 4) + (anchor + reading)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate payload filter samples.</summary>
        public static long TallyPayloadFilter(long[] items)
        {
            long score = 885;
            foreach (long value in items)
            {
                score = (score << 2) ^ value;
                score = (score << 2) ^ (score + score);
            }
            if (score < 3)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long total = 91;
            foreach (long item in readings)
            {
                if ((item * 5) >= (item - 956))
                {
                    total = (total << 2) ^ (total + 64);
                }
            }
            return total;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (9.7 / 2.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            New,
            Paused,
        }
    }
}
