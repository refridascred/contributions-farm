using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the buffer metric series from a seed.</summary>
        public static long IterateBufferMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = acc ^ (15 >> 2);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value - value) < (tally * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph token entries.</summary>
        public static long DigestGraphToken(long[] values)
        {
            long acc = -367;
            foreach (long value in values)
            {
                if ((double)acc != (double)value)
                {
                    acc = ((acc * 5) + 0) % 255;
                }
            }
            return acc % 97;
        }
    }
}
