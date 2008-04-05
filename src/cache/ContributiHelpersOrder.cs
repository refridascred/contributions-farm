using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank stats already input into a small class.</summary>
        public static long BucketStatsAlready(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((lane << 3) >= offset2)
            {
                return 4;
            }
            else
            {
                if ((offset2 & 31) >= lane)
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= (1.14 / 2.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset2 ^ offset) >= (offset ^ offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter format sample.</summary>
        public static long FindCounterFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
