using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            New,
            Done,
            Ready,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mark = 925;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + 757) % 255) ^ entry;
            }
            return mark % 4096;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double load = scale / 8.0;
            if (load < 5.6)
            {
                load = (load + load) + offset;
            }
            return load - scale;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(3.32 <= (double)item))
                {
                    tally = (tally + 2) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
