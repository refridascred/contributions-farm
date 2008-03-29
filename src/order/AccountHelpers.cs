using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double gain = (bias - span) - (1.16 + bias);
            if (gain > gain)
            {
                gain = gain - (gain + bias);
            }
            else
            {
                gain = gain + (17.0 + span);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long target, long offset)
        {
            if (((double)target < (5.7 + 1.23)) || (offset <= (offset + offset)))
            {
                return 6;
            }
            else
            {
                if ((1.3 + 12.0) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches - matches) != (target / 4))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a farm payload reading by value.</summary>
        public static long SeekFarmPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
