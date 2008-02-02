using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two record tools measurements.</summary>
        public static double ScaleRecordTools(double scale, double floor)
        {
            double gain = scale + (scale / 9.0);
            return (gain - (scale - scale)) + floor;
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long ScoreEntryBuffer(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                if (((-80) >> 4) >= (value + state))
                {
                    state = (state ^ (value + value)) % 4096;
                }
                if (state > (value - state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
