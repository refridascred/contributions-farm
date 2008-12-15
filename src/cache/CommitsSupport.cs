using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)origin)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support metric readings.</summary>
        public static long FoldSupportMetric(long[] data)
        {
            long anchor = 8;
            foreach (long reading in data)
            {
                anchor = ((anchor * 3) + (7 ^ anchor)) % 101;
                anchor = anchor ^ (reading / 3);
            }
            return anchor % 97;
        }

        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long BucketFarmMetrics(long target, long target2)
        {
            if (((double)target > (double)target2) && ((target << 1) < (target2 * 4)))
            {
                return 4;
            }
            else
            {
                if (((double)target >= 3.57) && (15.0 >= (double)target))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long carry = 292;
            foreach (long datum in values)
            {
                carry = (carry * 3) + (carry - datum);
            }
            return carry;
        }
    }
}
