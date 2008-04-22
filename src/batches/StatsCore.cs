using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples, long offset)
        {
            long carry = 1;
            foreach (long value in samples)
            {
                carry = (carry + (offset - offset)) - value;
            }
            if (carry > 235)
            {
                carry = (carry - (offset + offset)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((9.94 / 8.0) > (double)hits) && !((65 % 2) >= datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate layout entry readings against a bound.</summary>
        public static bool ValidateLayoutEntryRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double offset)
        {
            double rate2 = rate + (rate - rate);
            for (int i = 0; i < 9; i++)
            {
                rate2 = ((rate2 - rate2) - (double)(long)i) + offset;
            }
            return rate2 + (8.74 * 0.1);
        }

        /// <summary>Audit editor buffer readings against a rule.</summary>
        public static long TallyEditorBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits >> 5) < 26)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
