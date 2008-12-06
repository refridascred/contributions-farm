using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((double)tally == (2.06 + 0.1)) && ((661 > (tally >> 1)) && ((tally + datum) > datum)))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine account editor values into a single score.</summary>
        public static long TallyAccountEditor(long[] readings)
        {
            long anchor = 80;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 2) + anchor) % 255;
                if ((cell << 3) > (anchor >> 5))
                {
                    anchor = (anchor * 2) + anchor;
                }
                if ((2.0 + 5.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
