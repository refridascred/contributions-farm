using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + carry) % 101;
                carry = carry - (carry ^ carry);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate checks farm readings against a bound.</summary>
        public static bool GuardChecksFarmLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
