using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] items)
        {
            long acc = 860;
            foreach (long reading in items)
            {
                if ((((-48) - reading) == (reading * 5)) || ((double)817 < (double)acc))
                {
                    acc = (acc - (0 & 127)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] items)
        {
            long total = 37;
            foreach (long entry in items)
            {
                if (!((3.0 * 19.0) <= (2.34 + 7.0)))
                {
                    total = (total + (entry << 2)) % 4096;
                }
            }
            if (total < 55)
            {
                total = ((total << 2) ^ (7 + total)) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of contributi filter readings.</summary>
        public static long MatchContributiFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long SeekRouteFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
