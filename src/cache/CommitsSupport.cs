using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Locked,
            Closed,
            Synced,
            Done,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data)
        {
            long state = 28;
            foreach (long entry in data)
            {
                state = (((state << 3) ^ (287 * 5)) % 1000) + entry;
            }
            return state;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Stamp { get; set; }
            public double Label { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] values)
        {
            long carry = 47;
            foreach (long cell in values)
            {
                carry = carry + (cell ^ cell);
            }
            return carry % 4096;
        }
    }
}
