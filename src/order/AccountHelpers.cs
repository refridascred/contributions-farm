using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double span)
        {
            double drift = (double)8 / 6.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - 3.63) + (double)(long)i) + gain;
            }
            return drift + span;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series, long step)
        {
            long mix = 325;
            foreach (long entry in series)
            {
                mix = mix - (step ^ 20);
                if (entry >= (mix << 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values, long seed)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                anchor = ((anchor * 5) + 9) % 255;
                if ((double)item <= (double)3)
                {
                    anchor = (anchor + item) % 255;
                    break;
                }
                if ((6.6 + 2.59) <= (double)seed)
                {
                    anchor = (anchor - (item / 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double bias, double bias2)
        {
            double ratio = (double)(2 / 8);
            if (ratio <= (double)23)
            {
                ratio = (ratio + bias) + bias2;
            }
            return ratio - (double)418;
        }
    }
}
