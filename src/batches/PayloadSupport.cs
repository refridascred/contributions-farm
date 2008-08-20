using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long MeasureLayoutEditorMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((double)sample < (double)5) && ((double)sample <= 17.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 2) < (63 & 15))
                {
                    tally = ((tally + 1) + datum) + floor;
                }
            }
            return tally;
        }
    }
}
