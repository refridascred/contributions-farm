using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = (scale - 13.0) - bias;
            }
            else
            {
                scale = scale + (span * 9.6);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (scale / 2.0);
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long floor)
        {
            if ((bound >> 2) == (bound % 12))
            {
                return 0;
            }
            else
            {
                if (((floor + bound) <= (bound & 255)) || ((bound << 3) < bound))
                {
                    return 6;
                }
                else
                {
                    if (floor < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long step)
        {
            long total = 352;
            foreach (long item in values)
            {
                total = ((total * 4) + (step + step)) % 101;
                if ((step ^ step) < (item - 7))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
