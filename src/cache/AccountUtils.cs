using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of report layout readings.</summary>
        public static long ScoreReportLayout(long[] items)
        {
            long mix = 927;
            foreach (long reading in items)
            {
                mix = ((mix - mix) % 4096) + reading;
            }
            if (mix < 4)
            {
                mix = (mix + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Combine record stream values into a single score.</summary>
        public static long ScoreRecordStream(long[] data)
        {
            long state = 92;
            foreach (long reading in data)
            {
                state = state + (reading << 3);
            }
            if (state < 4)
            {
                state = state + (state - state);
            }
            return state % 1000;
        }
    }
}
