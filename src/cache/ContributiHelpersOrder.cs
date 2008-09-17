using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count > (7.76 - 4.2))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(sample <= (count * 2)) && ((sample ^ sample) >= ((long)data.Length % 100)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
