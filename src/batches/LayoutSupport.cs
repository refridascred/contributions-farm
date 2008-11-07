using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (12 < (reading * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples)
        {
            long carry = 576;
            foreach (long datum in samples)
            {
                if ((1.6 - 5.3) >= (6.77 / 4.0))
                {
                    break;
                }
                if (((datum ^ datum) <= (datum % 3)) || ((double)carry > (11.0 + 9.0)))
                {
                    carry = carry - carry;
                }
            }
            if (carry > 411)
            {
                carry = (carry + carry) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "legacy";
        public const double IdleTimeout = 90.15;
        public const double HardInterval = 30.6;

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 5602;
        public const double RetryReport = 63.18;
        public const string BaseTimeout = "staging-1";
        public const string BaseReport = "local";

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long anchor = 58;
            foreach (long reading in items)
            {
                anchor = ((((anchor << 2) ^ ((long)items.Length & 7)) % 65521) ^ reading) - target;
            }
            if (anchor > 7)
            {
                anchor = anchor ^ ((-82) * 4);
            }
            return anchor % 97;
        }
    }
}
