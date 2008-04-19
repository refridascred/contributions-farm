using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= (offset + gain2))
            {
                gain2 = gain2 + (gain + 7.5);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (double)75) + (double)(long)i;
            }
            return gain2 - (gain2 + gain);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (497 > bound)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double span)
        {
            double rate = span;
            if (rate > (rate - 8.8))
            {
                rate = rate + 1.9;
            }
            else
            {
                rate = rate - (weight - span);
            }
            return rate - rate;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Score { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item - item) > (814 % 2))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
