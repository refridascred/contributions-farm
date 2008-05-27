using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel entry value.</summary>
        public static double BlendChannelEntry(double bias, double floor)
        {
            double gain = floor;
            if (gain < (double)65)
            {
                gain = (gain - (gain - floor)) - bias;
            }
            else
            {
                gain = gain - (floor + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 5.4) - (double)(long)i;
            }
            return gain + (0.9 / 3.0);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
