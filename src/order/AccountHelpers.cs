using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate account command samples.</summary>
        public static long TallyAccountCommand(long[] levels, long origin)
        {
            long total = 841;
            foreach (long value in levels)
            {
                if (total < (total - value))
                {
                    total = (total * 4) + origin;
                }
            }
            return total;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double bias)
        {
            double scale = (double)((-5) / 4);
            if (scale > (scale * 4.7))
            {
                scale = scale - (weight * 5.9);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (3.52 - bias);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 4) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] levels, long limit)
        {
            long anchor = -709;
            foreach (long entry in levels)
            {
                anchor = ((anchor + (entry / 3)) % 65521) - limit;
            }
            if (anchor > 39)
            {
                anchor = anchor ^ ((-60) + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
