using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 75;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark ^ floor) % 1000) - (long)i) ^ sample;
                }
                if (mark >= ((-837) + floor))
                {
                    mark = (mark << 2) ^ (floor & 1);
                }
                else
                {
                    mark = (mark + (floor / 4)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Scale a token contributi figure with a bias.</summary>
        public static double ProjectTokenContributi(double bias, double floor)
        {
            double mean = floor;
            if (mean > (floor * 6.4))
            {
                mean = mean + (floor * 1.6);
            }
            return mean - (mean + bias);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
