using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long MeasureCounterReportMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (2.75 * 0.31))
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
