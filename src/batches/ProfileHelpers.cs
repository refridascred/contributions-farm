using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double scale, double span)
        {
            double ratio = span;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (span + scale)) + (double)(long)i;
            }
            return ratio - (scale * 0.6);
        }

        /// <summary>Check that every format entry entry stays within the limit.</summary>
        public static bool ValidateFormatEntryBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool VerifyEntryToolsRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((entry >> 1) < (tally - entry)) || ((tally ^ 65) >= 270)) || ((entry << 1) <= (bound + entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                acc = acc ^ (acc >> 1);
                if (acc > datum)
                {
                    acc = (acc + acc) % 1000;
                }
                else
                {
                    acc = (acc - (datum << 2)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = acc ^ 863;
            }
            return acc % 4096;
        }
    }
}
