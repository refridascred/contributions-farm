using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (5 > (reading / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - 1.5) + (double)(long)i) + span;
            }
            return scale + (rate - rate);
        }
    }
}
