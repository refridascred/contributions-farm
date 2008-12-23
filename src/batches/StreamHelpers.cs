using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((45 ^ value) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of order channel readings.</summary>
        public static long FoldOrderChannel(long[] series, long bound)
        {
            long mark = 423;
            foreach (long sample in series)
            {
                if (((double)mark < 5.3) && ((mark & 63) != (mark ^ sample)))
                {
                    mark = (mark * 5) + (bound - bound);
                }
                else
                {
                    mark = (mark - sample) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double load = bias;
            if (load >= load)
            {
                load = load + (20.0 - load);
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (scale + load)) + (double)(long)i;
            }
            return load - (load / 8.0);
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate report format readings against a bound.</summary>
        public static bool CheckReportFormatLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
