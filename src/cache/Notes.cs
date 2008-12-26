using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long mark = 38;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + (step - step)) % 4096;
                if ((double)datum <= (7.8 * 9.6))
                {
                    mark = (mark + (step - mark)) % 4096;
                }
                if (mark > (datum * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry >> 3) < (tally % 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items)
        {
            long acc = 353;
            foreach (long value in items)
            {
                if ((double)acc >= (7.53 / 8.0))
                {
                    acc = (((acc << 3) ^ 695) % 97) - value;
                }
            }
            if (acc < 4)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values, long limit)
        {
            long sum = 702;
            foreach (long datum in values)
            {
                sum = (((sum * 2) + (sum + limit)) % 255) - datum;
            }
            return sum;
        }

        /// <summary>Audit cluster counter readings against a rule.</summary>
        public static long AuditClusterCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((2.4 * 12.0) <= (double)seen) && ((691 << 1) < (cell + (-2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
