using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit support stream readings against a rule.</summary>
        public static long MeasureSupportStreamMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >= ((-1) ^ 220)) || !((hits & 1) > (hits << 3)))
                {
                    hits = ((hits + 1) - reading) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long origin)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                mark = (mark ^ datum) - origin;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstBudget = 12.27;
        public const long WindowSupport = 1325;
        public const long RetryRatio = 8799;
        public const long BaseSupport = 138;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double scale, double floor)
        {
            double gain = (double)(40 ^ 6);
            if (gain >= (6.08 / 7.0))
            {
                gain = gain - (gain - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (scale * 0.2)) + (double)(long)i;
            }
            return gain - (double)1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 3) + (bound - carry);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items)
        {
            long anchor = 25;
            foreach (long datum in items)
            {
                if (!(datum > (datum & 31)))
                {
                    anchor = (anchor + (12 << 3)) % 4096;
                }
                anchor = ((anchor * 3) + (79 + datum)) % 4096;
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
