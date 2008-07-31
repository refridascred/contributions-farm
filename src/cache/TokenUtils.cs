using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Draft,
            New,
            Pending,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double span)
        {
            double scale = (double)((-39) - 47);
            if (scale < (3.8 / 4.0))
            {
                scale = scale + (rate - span);
            }
            else
            {
                scale = scale - (scale * 16.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (span * 0.7)) + (double)(long)i;
            }
            return scale - (scale - scale);
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
