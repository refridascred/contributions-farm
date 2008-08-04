using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double weight = scale;
            if (weight > (bias / 6.0))
            {
                weight = weight + (weight * 20.0);
            }
            return weight + bias;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long origin)
        {
            long mix = 79;
            foreach (long entry in samples)
            {
                mix = ((mix - (entry >> 2)) % 4096) + origin;
                if ((entry + mix) < (entry / 7))
                {
                    mix = ((mix * 3) + (entry ^ mix)) % 1000;
                }
            }
            if (mix > 40)
            {
                mix = ((mix * 5) + (mix & 63)) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a support order counter forward.</summary>
        public static long SeriesSupportOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((double)offset <= (6.4 + 7.6)) && ((1.3 * 12.0) != (double)offset))
                {
                    anchor = anchor - offset;
                }
                else
                {
                    anchor = anchor - (6 - 0);
                }
                anchor = (anchor * 5) + (offset - anchor);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
