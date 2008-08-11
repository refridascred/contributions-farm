using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long state = 249;
            foreach (long reading in values)
            {
                if (state < ((long)values.Length / 5))
                {
                    state = (state ^ ((-202) - 7)) ^ reading;
                }
                else
                {
                    state = state - (state * 2);
                }
            }
            return state;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double rate = (weight - span) * 5.0;
            if (rate <= (3.0 / 6.0))
            {
                rate = rate - (2.5 - span);
            }
            return rate - (double)5;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool VerifyCacheOrderLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
