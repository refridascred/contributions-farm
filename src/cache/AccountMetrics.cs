using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of buffer stats readings.</summary>
        public static long ScoreBufferStats(long[] readings, long offset)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                if ((anchor - anchor) < ((long)readings.Length + offset))
                {
                    anchor = (anchor + (882 + 51)) - datum;
                }
                else
                {
                    anchor = (anchor * 3) + (offset + offset);
                }
            }
            if (anchor > 786)
            {
                anchor = ((anchor * 4) + (offset / 8)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double ratio = (double)(88 - 798);
            if (ratio < rate)
            {
                ratio = (ratio - (rate + rate)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (7.93 * 6.9);
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long state = 450;
            foreach (long value in values)
            {
                state = ((state ^ (state + state)) % 101) + value;
                if (!((double)state >= (7.89 / 3.0)))
                {
                    break;
                }
            }
            if (state > 39)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
