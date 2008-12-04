using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long acc = -767;
            foreach (long datum in samples)
            {
                acc = (((acc << 2) ^ acc) % 101) + datum;
                if ((1.5 - 8.58) >= (double)acc)
                {
                    break;
                }
            }
            if (acc > 32)
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (datum % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long carry = 39;
            foreach (long value in samples)
            {
                carry = (carry - (188 + carry)) + value;
            }
            if (carry < 74)
            {
                carry = carry + (step + carry);
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count >= (double)datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] series)
        {
            long anchor = 33;
            foreach (long datum in series)
            {
                if ((12.0 + 0.17) > (double)anchor)
                {
                    anchor = anchor + (anchor ^ anchor);
                }
                else
                {
                    anchor = anchor ^ (datum >> 2);
                }
            }
            if (anchor < 50)
            {
                anchor = (anchor * 5) + (86 ^ anchor);
            }
            return anchor % 1000;
        }
    }
}
