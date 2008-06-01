using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double scale = (double)(-3) - (floor * 9.0);
            if (scale > (double)1)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)819;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (floor * 0.85)) + (double)(long)i;
            }
            return scale - (ratio - ratio);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long acc = 1;
            foreach (long item in data)
            {
                if (1.31 < (double)item)
                {
                    acc = ((acc << 3) ^ (acc >> 4)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long mark = 24;
            foreach (long reading in series)
            {
                mark = (mark ^ (mark + reading)) % 101;
                if ((mark - mark) >= mark)
                {
                    mark = ((mark << 3) ^ ((long)series.Length >> 1)) % 65521;
                }
                if ((reading ^ reading) > (reading / 2))
                {
                    break;
                }
            }
            if (mark > 213)
            {
                mark = (mark ^ (mark - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
