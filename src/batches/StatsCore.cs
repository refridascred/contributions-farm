using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long floor)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                if (!((double)sum <= (19.0 / 5.0)))
                {
                    sum = (sum - (floor % 5)) - entry;
                }
            }
            return sum;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Retry,
            New,
            Ready,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels)
        {
            long mark = 48;
            foreach (long sample in levels)
            {
                if (sample >= (mark / 5))
                {
                    mark = mark + sample;
                }
                mark = (mark - (mark >> 4)) % 101;
                if ((mark - 7) >= (5 % 97))
                {
                    mark = mark ^ (mark & 7);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of command filter readings.</summary>
        public static long ScoreCommandFilter(long[] readings)
        {
            long sum = 70;
            foreach (long cell in readings)
            {
                sum = (sum * 5) + (sum + cell);
            }
            return sum % 97;
        }
    }
}
